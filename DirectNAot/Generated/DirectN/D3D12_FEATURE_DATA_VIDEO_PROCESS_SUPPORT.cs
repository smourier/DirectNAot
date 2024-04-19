namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_process_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT
{
    public uint NodeIndex;
    public D3D12_VIDEO_SAMPLE InputSample;
    public D3D12_VIDEO_FIELD_TYPE InputFieldType;
    public D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat;
    public DXGI_RATIONAL InputFrameRate;
    public D3D12_VIDEO_FORMAT OutputFormat;
    public D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat;
    public DXGI_RATIONAL OutputFrameRate;
    public D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags;
    public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;
    public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport;
    public D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport;
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport;
    public InlineArrayD3D12_VIDEO_PROCESS_FILTER_RANGE32 FilterRangeSupport;
}
