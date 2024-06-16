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

    public IComObject<T> ComObject => Disposable;
    public T NativeObject => Disposable.Object;
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

    bool IComObject.IsDisposed => Disposable.IsDisposed;
    System.Runtime.InteropServices.Marshalling.ComObject IComObject.Object => (System.Runtime.InteropServices.Marshalling.ComObject)(object)Disposable.Object!;
    T IComObject<T>.Object => Disposable.Object;
    Type IComObject.InterfaceType => typeof(T);
}
