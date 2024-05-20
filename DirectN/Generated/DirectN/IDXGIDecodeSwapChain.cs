#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgidecodeswapchain
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("2633066b-4514-4c7a-8fd8-12ea98059d18")]
public partial interface IDXGIDecodeSwapChain
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-presentbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PresentBuffer(uint BufferToPresent, uint SyncInterval, DXGI_PRESENT Flags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-setsourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceRect(in RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-settargetrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTargetRect(in RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-setdestsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDestSize(uint Width, uint Height);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-getsourcerect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceRect(out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-gettargetrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetRect(out RECT pRect);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-getdestsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDestSize(out uint pWidth, out uint pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-setcolorspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorSpace(DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS ColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgidecodeswapchain-getcolorspace
    [PreserveSig]
    DXGI_MULTIPLANE_OVERLAY_YCbCr_FLAGS GetColorSpace();
}
