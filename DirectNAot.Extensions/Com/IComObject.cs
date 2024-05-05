using System.Diagnostics.CodeAnalysis;

namespace DirectNAot.Extensions.Com
{
    public interface IComObject : IDisposable
    {
        [AllowNull]
        System.Runtime.InteropServices.Marshalling.ComObject Object { get; }
        Type InterfaceType { get; }
    }

    public interface IComObject<out T> : IComObject
    {
        [AllowNull]
        new T Object { get; }
    }
}
