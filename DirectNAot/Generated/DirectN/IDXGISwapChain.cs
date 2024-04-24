namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiswapchain
[GeneratedComInterface, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
public partial interface IDXGISwapChain : IDXGIDeviceSubObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-present
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Present(uint SyncInterval, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(uint Buffer, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-setfullscreenstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFullscreenState([MarshalAs(UnmanagedType.U4)] bool Fullscreen, IDXGIOutput? pTarget);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getfullscreenstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullscreenState(nint /* optional bool* */ pFullscreen, nint /* optional IDXGIOutput* */ ppTarget);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out DXGI_SWAP_CHAIN_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-resizebuffers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-resizetarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResizeTarget(in DXGI_MODE_DESC pNewTargetParameters);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getcontainingoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainingOutput(out IDXGIOutput ppOutput);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getframestatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getlastpresentcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastPresentCount(out uint pLastPresentCount);
}
