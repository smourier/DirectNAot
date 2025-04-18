#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_encoder_codec_configuration_support
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
    public BOOL IsSupported;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT CodecSupportLimits;
}
