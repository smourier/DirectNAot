namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dswapchain9
[GeneratedComInterface, Guid("794950f2-adfc-458a-905e-10a10b0b503b")]
public partial interface IDirect3DSwapChain9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9-present
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Present(FoundationRECT pSourceRect, FoundationRECT pDestRect, HWND hDestWindowOverride, in RGNDATA pDirtyRegion, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9-getfrontbufferdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrontBufferData(IDirect3DSurface9 pDestSurface);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9-getbackbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBackBuffer(uint iBackBuffer, D3DBACKBUFFER_TYPE Type, out IDirect3DSurface9 ppBackBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9-getrasterstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRasterStatus(ref D3DRASTER_STATUS pRasterStatus);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9-getdisplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDisplayMode(ref D3DDISPLAYMODE pMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9-getpresentparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPresentParameters(ref D3DPRESENT_PARAMETERS pPresentationParameters);
}
