namespace DirectNAot.Extensions.Com
{
    public interface IUnknownObject : IDisposable
    {
        ComObject? Object { get; }
        Type InterfaceType { get; }
    }

    public interface IUnknownObject<out T> : IUnknownObject
    {
        new T? Object { get; }
    }
}
