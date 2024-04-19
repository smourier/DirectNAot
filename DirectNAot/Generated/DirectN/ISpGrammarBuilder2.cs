namespace DirectN;

[GeneratedComInterface, Guid("8ab10026-20cc-4b20-8c22-a49c9ba78f60")]
public partial interface ISpGrammarBuilder2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTextSubset(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, PWSTR psz, SPMATCHINGMODE eMatchMode);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPhoneticAlphabet(PHONETICALPHABET phoneticALphabet);
}
