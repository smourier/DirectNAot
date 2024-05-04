#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("4b37bc9e-9ed6-44a3-93d3-18f022b79ec3")]
public partial interface ISpRecoGrammar2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRules(ref SPRULE ppCoMemRules, ref uint puNumRules);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadCmdFromFile2(PWSTR pszFileName, SPLOADOPTIONS Options, PWSTR? pszSharingUri, PWSTR? pszBaseUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadCmdFromMemory2(in SPBINARYGRAMMAR pGrammar, SPLOADOPTIONS Options, PWSTR? pszSharingUri, PWSTR? pszBaseUri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRulePriority(PWSTR pszRuleName, uint ulRuleId, int nRulePriority);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRuleWeight(PWSTR pszRuleName, uint ulRuleId, float flWeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDictationWeight(float flWeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGrammarLoader(ISpeechResourceLoader pLoader);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSMLSecurityManager(IInternetSecurityManager pSMLSecurityManager);
}
