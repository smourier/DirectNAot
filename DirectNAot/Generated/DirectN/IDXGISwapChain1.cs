namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgiswapchain1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa")]
public partial interface IDXGISwapChain1 : IDXGISwapChain
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getdesc1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc1(out DXGI_SWAP_CHAIN_DESC1 pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getfullscreendesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFullscreenDesc(out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-gethwnd
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetHwnd(out HWND pHwnd);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getcorewindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetCoreWindow(in Guid refiid, out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-present1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Present1(uint SyncInterval, uint PresentFlags, in DXGI_PRESENT_PARAMETERS pPresentParameters);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-istemporarymonosupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsTemporaryMonoSupported();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getrestricttooutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRestrictToOutput(out IDXGIOutput ppRestrictToOutput);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-setbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBackgroundColor(in DXGI_RGBA pColor);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getbackgroundcolor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBackgroundColor(out DXGI_RGBA pColor);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-setrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetRotation(DXGI_MODE_ROTATION Rotation);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_2/nf-dxgi1_2-idxgiswapchain1-getrotation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRotation(out DXGI_MODE_ROTATION pRotation);
}
