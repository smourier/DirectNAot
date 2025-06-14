namespace DirectN.Extensions.Utilities;

public abstract class InterlockedDisposable<T>(T? disposable) : IDisposable where T : class, IDisposable
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private T? _disposable = disposable;

    public bool IsDisposed => _disposable == null;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected T? RawDisposable => _disposable;

    public T Disposable
    {
        get
        {
            var disposable = _disposable;
            ObjectDisposedException.ThrowIf(disposable == null, this);
            return disposable!;
        }
    }

    protected virtual T? ExchangeDisposable(T? disposable)
    {
        // note there's no lock here
        var existing = _disposable;
        existing?.Dispose();
        return Interlocked.Exchange(ref _disposable, disposable);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            var disposable = Interlocked.Exchange(ref _disposable, null);
            disposable?.Dispose();
        }
    }

    public void Dispose() { Dispose(true); GC.SuppressFinalize(this); }
}
