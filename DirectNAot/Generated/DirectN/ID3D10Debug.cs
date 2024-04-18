namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nn-d3d10sdklayers-id3d10debug
[GeneratedComInterface, Guid("9b7e4e01-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Debug
{
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setfeaturemask
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFeatureMask(uint Mask);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-getfeaturemask
    [PreserveSig]
    public uint GetFeatureMask();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setpresentperrenderopdelay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPresentPerRenderOpDelay(uint Milliseconds);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-getpresentperrenderopdelay
    [PreserveSig]
    public uint GetPresentPerRenderOpDelay();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-setswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSwapChain(IDXGISwapChain pSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-getswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetSwapChain(out IDXGISwapChain ppSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10debug-validate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Validate();
}
