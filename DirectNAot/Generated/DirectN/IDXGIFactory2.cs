namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgifactory2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("50c83a1c-e072-4c48-87b0-3630fa36a6d0")]
public partial interface IDXGIFactory2 : IDXGIFactory1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsWindowedStereoEnabled();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForHwnd(nint pDevice, HWND hWnd, in DXGI_SWAP_CHAIN_DESC1 pDesc, in DXGI_SWAP_CHAIN_FULLSCREEN_DESC pFullscreenDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForCoreWindow(nint pDevice, nint pWindow, in DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSharedResourceAdapterLuid(HANDLE hResource, out LUID pLuid);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterStereoStatusWindow(HWND WindowHandle, uint wMsg, out uint pdwCookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterStereoStatusEvent(HANDLE hEvent, out uint pdwCookie);
    
    [PreserveSig]
    void UnregisterStereoStatus(uint dwCookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterOcclusionStatusWindow(HWND WindowHandle, uint wMsg, out uint pdwCookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterOcclusionStatusEvent(HANDLE hEvent, out uint pdwCookie);
    
    [PreserveSig]
    void UnregisterOcclusionStatus(uint dwCookie);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForComposition(nint pDevice, in DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
}
