#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_codec_picture_control_support_hevc
public partial struct D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC
{
    public uint MaxL0ReferencesForP;
    public uint MaxL0ReferencesForB;
    public uint MaxL1ReferencesForB;
    public uint MaxLongTermReferences;
    public uint MaxDPBCapacity;
}
