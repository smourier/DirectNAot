#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("12d7360f-a1c9-11d3-bc90-00c04f72df9f")]
public partial interface ISpITNProcessor
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadITNGrammar(PWSTR pszCLSID);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ITNPhrase(ISpPhraseBuilder pPhrase);
}
