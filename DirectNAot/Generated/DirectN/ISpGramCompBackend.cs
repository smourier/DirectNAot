namespace DirectN;

[GeneratedComInterface, Guid("3ddca27c-665c-4786-9f97-8c90c3488b61")]
public partial interface ISpGramCompBackend : ISpGrammarBuilder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSaveObjects(IStream pStream, ISpErrorLog pErrorLog);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitFromBinaryGrammar(in SPBINARYGRAMMAR pBinaryData);
}
