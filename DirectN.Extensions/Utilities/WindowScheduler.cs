namespace DirectN.Extensions.Utilities;

public class WindowScheduler(Window window) : TaskScheduler
{
    private ConcurrentQueue<Task>? _tasks = [];

    public Window Window { get; } = window ?? throw new ArgumentNullException(nameof(window));
    public virtual uint ProcessTasksMessage { get; set; } = Application.WM_APP_QUIT - 3;

    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) => false;
    protected override IEnumerable<Task> GetScheduledTasks() => _tasks ?? Enumerable.Empty<Task>();
    protected override void QueueTask(Task task)
    {
        ArgumentNullException.ThrowIfNull(task);
        var tasks = _tasks;
        if (tasks == null)
            return;

        tasks.Enqueue(task);
        Functions.PostMessageW(window.Handle, ProcessTasksMessage);
    }

    public virtual void ProcessTasks(bool throwOnError = true)
    {
        var tasks = Interlocked.Exchange(ref _tasks, new());
        if (tasks == null || tasks.IsEmpty)
            return;

        foreach (var task in tasks)
        {
            if (!TryExecuteTask(task) && throwOnError)
                throw new InvalidOperationException();
        }
    }
}
