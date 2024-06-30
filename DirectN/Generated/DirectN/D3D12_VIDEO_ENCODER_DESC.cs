#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_desc
public partial struct D3D12_VIDEO_ENCODER_DESC
{
    public uint NodeMask;
    public D3D12_VIDEO_ENCODER_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
    public D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE MaxMotionEstimationPrecision;
}
