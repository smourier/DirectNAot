#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspstorage4
[GeneratedComInterface, Guid("3133b2c4-515c-481b-b1ce-39327ecb4f74")]
public partial interface IMDSPStorage4 : IMDSPStorage3
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage4-setreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferences(uint dwRefs, nint /* optional IMDSPStorage* */ ppISPStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage4-getreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReferences(out uint pdwRefs, out nint pppISPStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage4-createstoragewithmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStorageWithMetadata(uint dwAttributes, PWSTR pwszName, IWMDMMetaData? pMetadata, ulong qwFileSize, out IMDSPStorage ppNewStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage4-getspecifiedmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpecifiedMetadata(uint cProperties, [MarshalUsing(CountElementName = nameof(cProperties))] in PWSTR[] ppwszPropNames, IWMDMMetaData? pMetadata);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage4-findstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindStorage(WMDM_FIND_SCOPE findScope, PWSTR pwszUniqueID, out IMDSPStorage ppStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage4-getparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParent(out IMDSPStorage ppStorage);
}
