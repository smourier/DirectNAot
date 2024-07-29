#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgidevice
[GeneratedComInterface, Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
public partial interface IDXGIDevice : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-getadapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAdapter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter>))] out IDXGIAdapter pAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSurface(in DXGI_SURFACE_DESC pDesc, uint NumSurfaces, DXGI_USAGE Usage, nint /* optional DXGI_SHARED_RESOURCE* */ pSharedResource, [In][Out][MarshalUsing(CountElementName = nameof(NumSurfaces))] IDXGISurface[] ppSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-queryresourceresidency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryResourceResidency([In][Out][MarshalUsing(CountElementName = nameof(NumResources))] nint[] ppResources, [In][Out][MarshalUsing(CountElementName = nameof(NumResources))] DXGI_RESIDENCY[] pResidencyStatus, uint NumResources);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-setgputhreadpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGPUThreadPriority(int Priority);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-getgputhreadpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGPUThreadPriority(out int pPriority);
}
