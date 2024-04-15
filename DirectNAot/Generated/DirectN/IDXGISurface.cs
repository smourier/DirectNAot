namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgisurface
[GeneratedComInterface, Guid("cafcb56c-6ac3-4889-bf47-9e23bbd260ec")]
public partial interface IDXGISurface : IDXGIDeviceSubObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_SURFACE_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Map(out DXGI_MAPPED_RECT pLockedRect, uint MapFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Unmap();
}
