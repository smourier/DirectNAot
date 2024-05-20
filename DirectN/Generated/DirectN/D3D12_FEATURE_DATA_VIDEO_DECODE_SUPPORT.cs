#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_decode_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_SUPPORT
{
    public uint NodeIndex;
    public D3D12_VIDEO_DECODE_CONFIGURATION Configuration;
    public uint Width;
    public uint Height;
    public DXGI_FORMAT DecodeFormat;
    public DXGI_RATIONAL FrameRate;
    public uint BitRate;
    public D3D12_VIDEO_DECODE_SUPPORT_FLAGS SupportFlags;
    public D3D12_VIDEO_DECODE_CONFIGURATION_FLAGS ConfigurationFlags;
    public D3D12_VIDEO_DECODE_TIER DecodeTier;
}
