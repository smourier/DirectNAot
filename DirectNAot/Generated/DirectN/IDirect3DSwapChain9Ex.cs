namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dswapchain9ex
[GeneratedComInterface, Guid("91886caf-1c3d-4d2e-a0ab-3e4c7d8d3303")]
public partial interface IDirect3DSwapChain9Ex : IDirect3DSwapChain9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9ex-getlastpresentcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastPresentCount(ref uint pLastPresentCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresentStats(ref D3DPRESENTSTATS pPresentationStatistics);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dswapchain9ex-getdisplaymodeex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDisplayModeEx(ref D3DDISPLAYMODEEX pMode, ref D3DDISPLAYROTATION pRotation);
}
