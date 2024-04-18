namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgifactory2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0")]
public partial interface IDXGIFactory2 : IDXGIFactory1
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-iswindowedstereoenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsWindowedStereoEnabled();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforhwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSwapChainForHwnd(nint pDevice, HWND hWnd, in DXGI_SWAP_CHAIN_DESC1 pDesc, nint /* DXGI_SWAP_CHAIN_FULLSCREEN_DESC */ pFullscreenDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforcorewindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSwapChainForCoreWindow(nint pDevice, nint pWindow, in DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-getsharedresourceadapterluid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSharedResourceAdapterLuid(HANDLE hResource, out LUID pLuid);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-registerstereostatuswindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterStereoStatusWindow(HWND WindowHandle, uint wMsg, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-registerstereostatusevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterStereoStatusEvent(HANDLE hEvent, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-unregisterstereostatus
    [PreserveSig]
    public void UnregisterStereoStatus(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-registerocclusionstatuswindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterOcclusionStatusWindow(HWND WindowHandle, uint wMsg, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-registerocclusionstatusevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterOcclusionStatusEvent(HANDLE hEvent, out uint pdwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-unregisterocclusionstatus
    [PreserveSig]
    public void UnregisterOcclusionStatus(uint dwCookie);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgifactory2-createswapchainforcomposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateSwapChainForComposition(nint pDevice, in DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
}
