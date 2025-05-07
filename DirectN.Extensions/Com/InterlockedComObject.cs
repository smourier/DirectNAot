namespace DirectN.Extensions.Com;

public abstract class InterlockedComObject<T> : InterlockedDisposable<IComObject<T>>, IComObject, IComObject<T>
{
    protected InterlockedComObject()
        : this(null)
    {
    }

    protected InterlockedComObject(IComObject<T>? comObject)
        : base(comObject)
    {
        if (comObject?.IsDisposed == true)
            throw new ArgumentException("Object is disposed.", nameof(comObject));
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public IComObject<T> ComObject => Disposable;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public T NativeObject => Disposable.Object;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    protected T? RawNativeObject
    {
        get
        {
            var comObject = RawDisposable;
            if (comObject == null)
                return default;

            return comObject.Object;
        }
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    bool IComObject.IsDisposed => Disposable.IsDisposed;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    System.Runtime.InteropServices.Marshalling.ComObject IComObject.Object => (System.Runtime.InteropServices.Marshalling.ComObject)(object)Disposable.Object!;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    T IComObject<T>.Object => Disposable.Object;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    Type IComObject.InterfaceType => typeof(T);

    void IComObject.AddRef() => Disposable.AddRef();
}
