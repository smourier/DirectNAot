namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/nn-dxgi1_3-idxgiswapchainmedia
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("dd95b90b-f05f-4f6a-bd65-25bfb264bd84")]
public partial interface IDXGISwapChainMedia
{
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchainmedia-getframestatisticsmedia
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFrameStatisticsMedia(out DXGI_FRAME_STATISTICS_MEDIA pStats);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchainmedia-setpresentduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPresentDuration(uint Duration);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi1_3/nf-dxgi1_3-idxgiswapchainmedia-checkpresentdurationsupport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CheckPresentDurationSupport(uint DesiredPresentDuration, out uint pClosestSmallerPresentDuration, out uint pClosestLargerPresentDuration);
}
