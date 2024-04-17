﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgifactorymedia
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("41e7d1f2-a591-4f7b-a2e5-fa9c843e1c12")]
public partial interface IDXGIFactoryMedia
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChainForCompositionSurfaceHandle(nint pDevice, HANDLE hSurface, DXGI_SWAP_CHAIN_DESC1 pDesc, IDXGIOutput pRestrictToOutput, out IDXGISwapChain1 ppSwapChain);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDecodeSwapChainForCompositionSurfaceHandle(nint pDevice, HANDLE hSurface, DXGI_DECODE_SWAP_CHAIN_DESC pDesc, IDXGIResource pYuvDecodeBuffers, IDXGIOutput pRestrictToOutput, out IDXGIDecodeSwapChain ppSwapChain);
}