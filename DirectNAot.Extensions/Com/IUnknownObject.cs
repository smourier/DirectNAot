using System.Diagnostics.CodeAnalysis;

namespace DirectNAot.Extensions.Com
{
    public interface IUnknownObject : IDisposable
    {
        [AllowNull]
        ComObject Object { get; }
        Type InterfaceType { get; }
    }

    public interface IUnknownObject<out T> : IUnknownObject
    {
        [AllowNull]
        new T Object { get; }
    }
}
