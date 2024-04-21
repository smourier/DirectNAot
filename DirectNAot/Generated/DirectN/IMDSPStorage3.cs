namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspstorage3
[GeneratedComInterface, Guid("6c669867-97ed-4a67-9706-1c5529d2a414")]
public partial interface IMDSPStorage3 : IMDSPStorage2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage3-getmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetadata(IWMDMMetaData? pMetadata);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspstorage3-setmetadata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMetadata(IWMDMMetaData? pMetadata);
}
