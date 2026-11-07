#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("9086bf22-9338-43bb-87ce-7790b6438a7f")]
public partial interface IDXGISwapChain5 : IDXGISwapChain4
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc2(out DXGI_SWAP_CHAIN_DESC2 pDesc);
    
    [PreserveSig]
    DXGI_COLOR_SPACE_TYPE GetColorSpace1();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeBuffers2(uint BufferCount, uint Width, uint Height, DXGI_FORMAT Format, uint SwapChainFlags, nint /* optional uint* */ pCreationNodeMask, nint /* optional nint* */ ppPresentQueue, DXGI_COLOR_SPACE_TYPE ColorSpace);
}
