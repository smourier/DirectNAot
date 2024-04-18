namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/nn-dxgi1_4-idxgiswapchain3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("94d99bdb-f1f8-4ab0-b236-7da0170edab1")]
public partial interface IDXGISwapChain3 : IDXGISwapChain2
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-getcurrentbackbufferindex
    [PreserveSig]
    public uint GetCurrentBackBufferIndex();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-checkcolorspacesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CheckColorSpaceSupport(DXGI_COLOR_SPACE_TYPE ColorSpace, out uint pColorSpaceSupport);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-setcolorspace1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetColorSpace1(DXGI_COLOR_SPACE_TYPE ColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-resizebuffers1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ResizeBuffers1(uint BufferCount, uint Width, uint Height, DXGI_FORMAT Format, uint SwapChainFlags, in uint pCreationNodeMask, nint ppPresentQueue);
}
