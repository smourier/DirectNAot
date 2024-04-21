namespace DirectN;

[GeneratedComInterface, Guid("b1e29d58-a675-11d2-8302-00c04f8ee6c0")]
public partial interface ISpGrammarCompiler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompileStream(IStream pSource, IStream pDest, IStream? pHeader, nint pReserved, ISpErrorLog? pErrorLog, uint dwFlags);
}
