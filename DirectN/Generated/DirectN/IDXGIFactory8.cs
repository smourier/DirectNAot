#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("693c45c1-39a7-4c1f-bdd3-d9a3229b8321")]
public partial interface IDXGIFactory8 : IDXGIFactory7
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForHwnd1(nint pDevice, HWND hWnd, in DXGI_SWAP_CHAIN_DESC2 pDesc, nint /* optional DXGI_SWAP_CHAIN_FULLSCREEN_DESC* */ pFullscreenDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutput?>))] IDXGIOutput? pRestrictToOutput, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain5>))] out IDXGISwapChain5 ppSwapChain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForCoreWindow1(nint pDevice, nint pWindow, in DXGI_SWAP_CHAIN_DESC2 pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutput?>))] IDXGIOutput? pRestrictToOutput, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain5>))] out IDXGISwapChain5 ppSwapChain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForComposition1(nint pDevice, in DXGI_SWAP_CHAIN_DESC2 pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutput?>))] IDXGIOutput? pRestrictToOutput, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain5>))] out IDXGISwapChain5 ppSwapChain);
}
