namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgidevice
[GeneratedComInterface, Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c")]
public partial interface IDXGIDevice : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-getadapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAdapter(out IDXGIAdapter pAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-createsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSurface(in DXGI_SURFACE_DESC pDesc, uint NumSurfaces, DXGI_USAGE Usage, nint/* nint */ pSharedResource, out IDXGISurface ppSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-queryresourceresidency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT QueryResourceResidency(nint ppResources, out DXGI_RESIDENCY pResidencyStatus, uint NumResources);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-setgputhreadpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetGPUThreadPriority(int Priority);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgidevice-getgputhreadpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetGPUThreadPriority(out int pPriority);
}
