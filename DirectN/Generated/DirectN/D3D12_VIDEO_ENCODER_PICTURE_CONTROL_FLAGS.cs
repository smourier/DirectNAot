#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_encoder_picture_control_flags
[Flags]
public enum D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS
{
    D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_NONE = 0,
    D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAG_USED_AS_REFERENCE_PICTURE = 1,
}
