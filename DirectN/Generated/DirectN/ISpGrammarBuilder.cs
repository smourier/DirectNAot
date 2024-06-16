#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8137828f-591a-4a42-be58-49ea7ebaac68")]
public partial interface ISpGrammarBuilder
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetGrammar(ushort NewLanguage);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRule(PWSTR pszRuleName, uint dwRuleId, uint dwAttributes, BOOL fCreateIfNotExist, ref SPSTATEHANDLE phInitialState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearRule(SPSTATEHANDLE hState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNewState(SPSTATEHANDLE hState, ref SPSTATEHANDLE phState);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddWordTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, PWSTR psz, PWSTR pszSeparators, SPGRAMMARWORDTYPE eWordType, float Weight, in SPPROPERTYINFO pPropInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRuleTransition(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, SPSTATEHANDLE hRule, float Weight, in SPPROPERTYINFO pPropInfo);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddResource(SPSTATEHANDLE hRuleState, PWSTR pszResourceName, PWSTR pszResourceValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit(uint dwReserved);
}
