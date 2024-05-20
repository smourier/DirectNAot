#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgiswapchain2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("a8be2ac4-199f-4946-b331-79599fb98de7")]
public partial interface IDXGISwapChain2 : IDXGISwapChain1
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchain2-setsourcesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSourceSize(uint Width, uint Height);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchain2-getsourcesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSourceSize(out uint pWidth, out uint pHeight);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchain2-setmaximumframelatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaximumFrameLatency(uint MaxLatency);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchain2-getmaximumframelatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMaximumFrameLatency(out uint pMaxLatency);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchain2-getframelatencywaitableobject
    [PreserveSig]
    HANDLE GetFrameLatencyWaitableObject();
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchain2-setmatrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMatrixTransform(in DXGI_MATRIX_3X2_F pMatrix);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchain2-getmatrixtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatrixTransform(out DXGI_MATRIX_3X2_F pMatrix);
}
