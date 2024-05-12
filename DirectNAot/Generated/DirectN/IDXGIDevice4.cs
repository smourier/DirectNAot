#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_5/nn-dxgi1_5-idxgidevice4
[GeneratedComInterface, Guid("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10")]
public partial interface IDXGIDevice4 : IDXGIDevice3
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_5/nf-dxgi1_5-idxgidevice4-offerresources1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OfferResources1(uint NumResources, [MarshalUsing(CountElementName = nameof(NumResources))] in IDXGIResource[] ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_5/nf-dxgi1_5-idxgidevice4-reclaimresources1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReclaimResources1(uint NumResources, [MarshalUsing(CountElementName = nameof(NumResources))] in IDXGIResource[] ppResources, [MarshalUsing(CountElementName = nameof(NumResources))] ref DXGI_RECLAIM_RESOURCE_RESULTS[] pResults);
}
