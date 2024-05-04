#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_encoder_frame_type_hevc
public enum D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC
{
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_I_FRAME = 0,
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_P_FRAME = 1,
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_B_FRAME = 2,
    D3D12_VIDEO_ENCODER_FRAME_TYPE_HEVC_IDR_FRAME = 3,
}
