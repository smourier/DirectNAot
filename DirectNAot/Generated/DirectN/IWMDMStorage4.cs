namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmstorage4
[GeneratedComInterface, Guid("c225bac5-a03a-40b8-9a23-91cf478c64a6")]
public partial interface IWMDMStorage4 : IWMDMStorage3
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-setreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReferences(uint dwRefs, nint/* nint */ ppIWMDMStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getreferences
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReferences(out uint pdwRefs, out IWMDMStorage pppIWMDMStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getrightswithprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRightsWithProgress(IWMDMProgress3 pIProgressCallback, out WMDMRIGHTS ppRights, out uint pnRightsCount);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getspecifiedmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSpecifiedMetadata(uint cProperties, in PWSTR ppwszPropNames, out IWMDMMetaData ppMetadata);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-findstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FindStorage(WMDM_FIND_SCOPE findScope, PWSTR pwszUniqueID, out IWMDMStorage ppStorage);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmstorage4-getparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParent(out IWMDMStorage ppStorage);
}
