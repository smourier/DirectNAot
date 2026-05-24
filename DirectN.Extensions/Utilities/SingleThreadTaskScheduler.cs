namespace DirectN.Extensions.Utilities;

public class SingleThreadTaskScheduler : TaskScheduler, IDisposable
{
    private readonly AutoResetEvent _stop = new(false);
    private readonly AutoResetEvent _dequeue = new(false);
    private readonly ConcurrentQueue<Task> _tasks = new();
    private readonly Stopwatch _stopWatch = new();
    private bool _disposedValue;

    public event EventHandler? Executing;
    public event EventHandler? Executed;
    public event EventHandler<ValueEventArgs<Exception>>? Error;

    public SingleThreadTaskScheduler(string threadName)
        : this(t =>
        {
            if (threadName != null)
            {
                t.Name = threadName;
            }
            return true;
        })
    {
    }

    public SingleThreadTaskScheduler(Func<Thread, bool>? threadConfigure = null)
    {
        DisposeThreadJoinTimeout = 1000;
        WaitTimeout = 1000;
        Thread = new Thread(SafeThreadExecute) { IsBackground = true };
        if (threadConfigure != null && !threadConfigure(Thread))
            return;

        Thread.Name ??= string.Format("_stts{0}", GetHashCode());
        Thread.Start();
    }

    protected ConcurrentQueue<Task> Tasks => _tasks;
    public Thread Thread { get; }
    public TimeSpan CurrentExecutionTime => _stopWatch.Elapsed;
    public DateTime LastDequeue { get; protected set; }
    public virtual bool ContinueOnError { get; set; }
    public virtual bool DequeueOnDispose { get; set; }
    public virtual int DisposeThreadJoinTimeout { get; set; }
    public virtual int WaitTimeout { get; set; }
    public virtual int DequeueTimeout { get; set; }
    public int QueueCount => _tasks.Count;

    public virtual void ClearQueue() => Dequeue(false);
    public virtual bool TriggerDequeue()
    {
        if (DequeueTimeout <= 0)
            return _dequeue != null && _dequeue.Set();

        var ts = DateTime.Now - LastDequeue;
        if (ts.TotalMilliseconds < DequeueTimeout)
            return false;

        LastDequeue = DateTime.Now;
        return _dequeue != null && _dequeue.Set();
    }

    protected virtual int Dequeue(bool execute)
    {
        var count = 0;
        do
        {
            if (!_tasks.TryDequeue(out var task))
                break;

            if (execute)
            {
                _stopWatch.Restart();
                OnExecuting(this, EventArgs.Empty);
                try
                {
                    TryExecuteTask(task);
                }
                catch (Exception ex)
                {
                    var e = new ValueEventArgs<Exception>(ex, true, true);
                    OnError(this, e);
                    if (e.Cancel)
                        break;

                    if (!ContinueOnError)
                        throw;
                }
                OnExecuted(this, EventArgs.Empty);
                _stopWatch.Stop();
            }
            count++;
        }
        while (true);
        return count;
    }

    private void SafeThreadExecute()
    {
#if DEBUG
        if (Debugger.IsAttached)
        {
            ThreadExecute();
            return;
        }
#endif

        try
        {
            ThreadExecute();
        }
        catch
        {
            // continue
        }
    }

    protected virtual void ThreadExecute()
    {
        do
        {
            if (_stop == null || _dequeue == null)
                return;

            _ = Dequeue(true);

            // note: Stop must be first in array (in case both events happen at the same exact time)
            var i = WaitHandle.WaitAny([_stop, _dequeue], WaitTimeout);
            if (i == 0)
                break;

            // note: we can dequeue on _dequeue event, or on timeout
            _ = Dequeue(true);
        }
        while (true);
    }

    protected virtual void OnExecuting(object sender, EventArgs e) => Executing?.Invoke(this, e);
    protected virtual void OnExecuted(object sender, EventArgs e) => Executed?.Invoke(this, e);
    protected virtual void OnError(object sender, ValueEventArgs<Exception> e) => Error?.Invoke(this, e);

    protected override void QueueTask(Task task)
    {
        ArgumentNullException.ThrowIfNull(task);
        _tasks.Enqueue(task);
        TriggerDequeue();
    }

    protected override IEnumerable<Task> GetScheduledTasks() => _tasks;
    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) => false;

    public void Dispose() { Dispose(disposing: true); GC.SuppressFinalize(this); }
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposedValue)
        {
            if (disposing)
            {
                _stop.Set();
                _stop.SafeDispose();

                _dequeue.SafeDispose();

                if (DequeueOnDispose)
                {
                    Dequeue(true);
                }

                if (Thread.IsAlive)
                {
                    Thread.Join(DisposeThreadJoinTimeout);
                }
            }

            _disposedValue = true;
        }
    }
}
