namespace DirectN.Extensions.Com;

public interface IComObject : IDisposable
{
    bool IsDisposed { get; }
    void AddRef();

    [AllowNull]
    System.Runtime.InteropServices.Marshalling.ComObject Object { get; }
    Type InterfaceType { get; }
}

public interface IComObject<out T> : IComObject
{
    [AllowNull]
    new T Object { get; }
}
