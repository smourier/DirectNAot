namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_decode_formats
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_FORMATS
{
    public uint NodeIndex;
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
    public uint FormatCount;
    public nint pOutputFormats;
}
