#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b1e29d58-a675-11d2-8302-00c04f8ee6c0")]
public partial interface ISpGrammarCompiler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pSource, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pDest, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream?>))] IStream? pHeader, nint pReserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpErrorLog?>))] ISpErrorLog? pErrorLog, uint dwFlags);
}
