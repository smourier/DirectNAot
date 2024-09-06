#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3ddevice9ex
[GeneratedComInterface, Guid("b18b10ce-2649-405a-870f-95f777d4313a")]
public partial interface IDirect3DDevice9Ex : IDirect3DDevice9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-setconvolutionmonokernel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConvolutionMonoKernel(uint width, uint height, ref float rows, ref float columns);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-composerects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComposeRects(IDirect3DSurface9 pSrc, IDirect3DSurface9 pDst, IDirect3DVertexBuffer9 pSrcRectDescs, uint NumRects, IDirect3DVertexBuffer9 pDstRectDescs, D3DCOMPOSERECTSOP Operation, int Xoffset, int Yoffset);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-presentex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PresentEx(in RECT pSourceRect, in RECT pDestRect, HWND hDestWindowOverride, in RGNDATA pDirtyRegion, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-getgputhreadpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGPUThreadPriority(ref int pPriority);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-setgputhreadpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGPUThreadPriority(int Priority);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-waitforvblank
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForVBlank(uint iSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-checkresourceresidency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckResourceResidency([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DResource9>))] out IDirect3DResource9 pResourceArray, uint NumResources);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-setmaximumframelatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaximumFrameLatency(uint MaxLatency);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-getmaximumframelatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaximumFrameLatency(ref uint pMaxLatency);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-checkdevicestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckDeviceState(HWND hDestinationWindow);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-createrendertargetex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRenderTargetEx(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, BOOL Lockable, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppSurface, ref HANDLE pSharedHandle, uint Usage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-createoffscreenplainsurfaceex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateOffscreenPlainSurfaceEx(uint Width, uint Height, D3DFORMAT Format, D3DPOOL Pool, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppSurface, ref HANDLE pSharedHandle, uint Usage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-createdepthstencilsurfaceex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDepthStencilSurfaceEx(uint Width, uint Height, D3DFORMAT Format, D3DMULTISAMPLE_TYPE MultiSample, uint MultisampleQuality, BOOL Discard, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DSurface9>))] out IDirect3DSurface9 ppSurface, ref HANDLE pSharedHandle, uint Usage);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-resetex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetEx(ref D3DPRESENT_PARAMETERS pPresentationParameters, ref D3DDISPLAYMODEEX pFullscreenDisplayMode);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3ddevice9ex-getdisplaymodeex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayModeEx(uint iSwapChain, ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
}
