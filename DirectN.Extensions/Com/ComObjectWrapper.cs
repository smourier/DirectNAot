namespace DirectN.Extensions.Com;

public sealed class ComObjectWrapper<T> : IComObject, IDisposable
{
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private readonly IComObject<T> _cot;

    public ComObjectWrapper(object obj)
    {
        ArgumentNullException.ThrowIfNull(obj);
        var cot = obj as IComObject<T>;
        if (cot == null)
        {
            if (obj is T t)
            {
                cot = new ComObject<T>(t);
            }
            else
            {
                if (obj is IComObject co)
                {
                    if (co.IsDisposed)
                        throw new ArgumentException("Input of type '" + obj.GetType() + "' is disposed.", nameof(obj));

                    if (co.Object is T t2)
                    {
                        cot = new ComObject<T>(t2);
                    }
                }

                if (cot == null)
                    throw new ArgumentException("Input of type '" + obj.GetType() + "' must be assignable to type '" + typeof(T) + "'.", nameof(obj));
            }
        }

        if (cot.IsDisposed)
            throw new ArgumentException("Input of type '" + obj.GetType() + "' is disposed.", nameof(obj));

        _cot = cot;
    }

    public T Object => _cot.Object;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public IComObject<T> ComObject => _cot;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    bool IComObject.IsDisposed => _cot.IsDisposed;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    System.Runtime.InteropServices.Marshalling.ComObject IComObject.Object => (Object as System.Runtime.InteropServices.Marshalling.ComObject)!;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    Type IComObject.InterfaceType => typeof(T);

    public void Dispose()
    {
        if (_cot.IsDisposed)
            return;

        _cot.Dispose();
    }
}