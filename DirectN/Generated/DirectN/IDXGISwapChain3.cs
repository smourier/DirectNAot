#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/nn-dxgi1_4-idxgiswapchain3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("94d99bdb-f1f8-4ab0-b236-7da0170edab1")]
public partial interface IDXGISwapChain3 : IDXGISwapChain2
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-getcurrentbackbufferindex
    [PreserveSig]
    uint GetCurrentBackBufferIndex();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-checkcolorspacesupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckColorSpaceSupport(DXGI_COLOR_SPACE_TYPE ColorSpace, out uint pColorSpaceSupport);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-setcolorspace1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorSpace1(DXGI_COLOR_SPACE_TYPE ColorSpace);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_4/nf-dxgi1_4-idxgiswapchain3-resizebuffers1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeBuffers1(uint BufferCount, uint Width, uint Height, DXGI_FORMAT Format, uint SwapChainFlags, [In][MarshalUsing(CountElementName = nameof(BufferCount))] uint[] pCreationNodeMask, [In][Out][MarshalUsing(CountElementName = nameof(BufferCount))] nint[] ppPresentQueue);
}
