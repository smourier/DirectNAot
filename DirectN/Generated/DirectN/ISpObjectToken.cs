#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("14056589-e16c-11d2-bb90-00c04f8ee6c0")]
public partial interface ISpObjectToken : ISpDataKey
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetId(PWSTR pszCategoryId, PWSTR pszTokenId, BOOL fCreateIfNotExist);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetId(out PWSTR ppszCoMemTokenId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCategory([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectTokenCategory>))] out ISpObjectTokenCategory ppTokenCategory);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(nint pUnkOuter, uint dwClsContext, in Guid riid, out nint ppvObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorageFileName(in Guid clsidCaller, PWSTR pszValueName, PWSTR pszFileNameSpecifier, uint nFolder, out PWSTR ppszFilePath);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStorageFileName(in Guid clsidCaller, PWSTR pszKeyName, BOOL fDeleteFile);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(nint /* optional Guid* */ pclsidCaller);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsUISupported(PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, nint punkObject, ref BOOL pfSupported);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayUI(HWND hwndParent, PWSTR pszTitle, PWSTR pszTypeOfUI, nint pvExtraData, uint cbExtraData, nint punkObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MatchesAttributes(PWSTR pszAttributes, ref BOOL pfMatches);
}
