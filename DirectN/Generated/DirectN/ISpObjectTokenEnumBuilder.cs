#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("06b64f9f-7fda-11d2-b4f2-00c04f797396")]
public partial interface ISpObjectTokenEnumBuilder : IEnumSpObjectTokens
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAttribs(PWSTR pszReqAttribs, PWSTR pszOptAttribs);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTokens(uint cTokens, in ISpObjectToken pToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTokensFromDataKey(ISpDataKey pDataKey, PWSTR pszSubKey, PWSTR pszCategoryId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTokensFromTokenEnum(IEnumSpObjectTokens pTokenEnum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Sort(PWSTR pszTokenIdToListFirst);
}
