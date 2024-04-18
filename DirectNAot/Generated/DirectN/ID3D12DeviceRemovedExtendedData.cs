namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12deviceremovedextendeddata
[GeneratedComInterface, Guid("98931d33-5ae8-4791-aa3c-1a73a2934e71")]
public partial interface ID3D12DeviceRemovedExtendedData
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12deviceremovedextendeddata-getautobreadcrumbsoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAutoBreadcrumbsOutput(out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT pOutput);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12deviceremovedextendeddata-getpagefaultallocationoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPageFaultAllocationOutput(out D3D12_DRED_PAGE_FAULT_OUTPUT pOutput);
}
