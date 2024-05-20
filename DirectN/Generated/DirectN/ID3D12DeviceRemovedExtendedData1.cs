#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9727a022-cf1d-4dda-9eba-effa653fc506")]
public partial interface ID3D12DeviceRemovedExtendedData1 : ID3D12DeviceRemovedExtendedData
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutoBreadcrumbsOutput1(out D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 pOutput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPageFaultAllocationOutput1(out D3D12_DRED_PAGE_FAULT_OUTPUT1 pOutput);
}
