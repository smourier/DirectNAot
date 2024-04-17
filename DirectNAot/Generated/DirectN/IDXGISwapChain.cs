﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiswapchain
[GeneratedComInterface, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
public partial interface IDXGISwapChain : IDXGIDeviceSubObject
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Present(uint SyncInterval, uint Flags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(uint Buffer, Guid riid, out nint ppSurface);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullscreenState([MarshalAs(UnmanagedType.U4)]bool Fullscreen, IDXGIOutput pTarget);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullscreenState([MarshalAs(UnmanagedType.U4)]out bool pFullscreen, out IDXGIOutput ppTarget);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_SWAP_CHAIN_DESC pDesc);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeTarget(DXGI_MODE_DESC pNewTargetParameters);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainingOutput(out IDXGIOutput ppOutput);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastPresentCount(out uint pLastPresentCount);
}