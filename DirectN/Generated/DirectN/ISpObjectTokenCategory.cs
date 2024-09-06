#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2d3d3845-39af-4850-bbf9-40b49780011d")]
public partial interface ISpObjectTokenCategory : ISpDataKey
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetId(PWSTR pszCategoryId, BOOL fCreateIfNotExist);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetId(out PWSTR ppszCoMemCategoryId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataKey(SPDATAKEYLOCATION spdkl, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpDataKey>))] out ISpDataKey ppDataKey);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTokens(PWSTR pzsReqAttribs, PWSTR pszOptAttribs, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSpObjectTokens>))] out IEnumSpObjectTokens ppEnum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDefaultTokenId(PWSTR pszTokenId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultTokenId(out PWSTR ppszCoMemTokenId);
}
