#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_process_reference_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_REFERENCE_INFO
{
    public uint NodeIndex;
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceMode;
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS Filters;
    public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;
    public DXGI_RATIONAL InputFrameRate;
    public DXGI_RATIONAL OutputFrameRate;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool EnableAutoProcessing;
    public uint PastFrames;
    public uint FutureFrames;
}
