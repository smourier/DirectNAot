namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgiswapchain
[GeneratedComInterface, Guid("310d36a0-d2e7-4c0a-aa04-6a9d23b8886a")]
public partial interface IDXGISwapChain : IDXGIDeviceSubObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-present
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Present(uint SyncInterval, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetBuffer(uint Buffer, in Guid riid, out nint ppSurface);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-setfullscreenstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFullscreenState([MarshalAs(UnmanagedType.U4)] bool Fullscreen, IDXGIOutput pTarget);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getfullscreenstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFullscreenState(nint/* nint */ pFullscreen, nint/* nint */ ppTarget);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetDesc(out DXGI_SWAP_CHAIN_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-resizebuffers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ResizeBuffers(uint BufferCount, uint Width, uint Height, DXGI_FORMAT NewFormat, uint SwapChainFlags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-resizetarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ResizeTarget(in DXGI_MODE_DESC pNewTargetParameters);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getcontainingoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetContainingOutput(out IDXGIOutput ppOutput);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getframestatistics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrameStatistics(out DXGI_FRAME_STATISTICS pStats);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgiswapchain-getlastpresentcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetLastPresentCount(out uint pLastPresentCount);
}
