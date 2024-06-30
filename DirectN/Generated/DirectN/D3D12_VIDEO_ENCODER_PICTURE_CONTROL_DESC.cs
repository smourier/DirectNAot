#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_control_desc
public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC
{
    public uint IntraRefreshFrameIndex;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA PictureControlCodecData;
    public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES ReferenceFrames;
}
