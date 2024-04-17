namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_2/nn-dxgi1_2-idxgiswapchain1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("790a45f7-0d42-4876-983a-0a55cfe6f4aa")]
public partial interface IDXGISwapChain1 : IDXGISwapChain
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc1(out DXGI_SWAP_CHAIN_DESC1 pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullscreenDesc(out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetHwnd(out HWND pHwnd);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCoreWindow(in Guid refiid, out nint ppUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Present1(uint SyncInterval, uint PresentFlags, in DXGI_PRESENT_PARAMETERS pPresentParameters);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsTemporaryMonoSupported();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRestrictToOutput(out IDXGIOutput ppRestrictToOutput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBackgroundColor(in DXGI_RGBA pColor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBackgroundColor(out DXGI_RGBA pColor);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRotation(DXGI_MODE_ROTATION Rotation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRotation(out DXGI_MODE_ROTATION pRotation);
}
