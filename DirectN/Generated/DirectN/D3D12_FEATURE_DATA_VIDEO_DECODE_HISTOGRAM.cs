#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_decode_histogram
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM
{
    public uint NodeIndex;
    public Guid DecodeProfile;
    public uint Width;
    public uint Height;
    public DXGI_FORMAT DecodeFormat;
    public D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS Components;
    public uint BinCount;
    public uint CounterBitDepth;
}
