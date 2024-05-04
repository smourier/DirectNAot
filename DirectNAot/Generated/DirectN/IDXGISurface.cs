#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgisurface
[GeneratedComInterface, Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec")]
public partial interface IDXGISurface : IDXGIDeviceSubObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgisurface-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_SURFACE_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgisurface-map
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Map(out DXGI_MAPPED_RECT pLockedRect, uint MapFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgisurface-unmap
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unmap();
}
