﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgifactorymedia
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("41e7d1f2-a591-4f7b-a2e5-fa9c843e1c12")]
public partial interface IDXGIFactoryMedia
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgifactorymedia-createswapchainforcompositionsurfacehandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForCompositionSurfaceHandle(nint pDevice, HANDLE hSurface, in DXGI_SWAP_CHAIN_DESC1 pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutput?>))] IDXGIOutput? pRestrictToOutput, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain1>))] out IDXGISwapChain1 ppSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgifactorymedia-createdecodeswapchainforcompositionsurfacehandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(nint pDevice, HANDLE hSurface, in DXGI_DECODE_SWAP_CHAIN_DESC pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIResource>))] IDXGIResource pYuvDecodeBuffers, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIOutput?>))] IDXGIOutput? pRestrictToOutput, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIDecodeSwapChain>))] out IDXGIDecodeSwapChain ppSwapChain);
}
