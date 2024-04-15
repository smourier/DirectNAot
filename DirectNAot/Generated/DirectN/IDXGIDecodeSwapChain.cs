namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgidecodeswapchain
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("2633066b-4514-4c7a-8fd8-12ea98059d18")]
public partial interface IDXGIDecodeSwapChain
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PresentBuffer(uint BufferToPresent, uint SyncInterval, uint Flags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceRect(RECT pRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTargetRect(RECT pRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDestSize(uint Width, uint Height);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceRect(out RECT pRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetRect(out RECT pRect);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDestSize(out uint pWidth, out uint pHeight);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace);
    
    [PreserveSig]
    DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace();
}
