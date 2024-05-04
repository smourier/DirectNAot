#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2d3d3845-39af-4850-bbf9-40b49780011d")]
public partial interface ISpObjectTokenCategory : ISpDataKey
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetId(PWSTR pszCategoryId, [MarshalAs(UnmanagedType.U4)] bool fCreateIfNotExist);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetId(out PWSTR ppszCoMemCategoryId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, out ISpDataKey ppDataKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTokens(PWSTR? pzsReqAttribs, PWSTR? pszOptAttribs, out IEnumSpObjectTokens ppEnum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultTokenId(PWSTR pszTokenId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultTokenId(out PWSTR ppszCoMemTokenId);
}
