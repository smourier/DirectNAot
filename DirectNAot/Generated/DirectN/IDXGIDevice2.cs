#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgidevice2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("05008617-fbfd-4051-a790-144884b4f6a9")]
public partial interface IDXGIDevice2 : IDXGIDevice1
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgidevice2-offerresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OfferResources(uint NumResources, [In][MarshalUsing(CountElementName = nameof(NumResources))] IDXGIResource[] ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgidevice2-reclaimresources
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReclaimResources(uint NumResources, [In][MarshalUsing(CountElementName = nameof(NumResources))] IDXGIResource[] ppResources, nint /* optional bool* */ pDiscarded);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgidevice2-enqueuesetevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnqueueSetEvent(HANDLE hEvent);
}
