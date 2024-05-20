#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_process_alpha_fill_mode
public enum D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE
{
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_OPAQUE = 0,
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_BACKGROUND = 1,
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_DESTINATION = 2,
    D3D12_VIDEO_PROCESS_ALPHA_FILL_MODE_SOURCE_STREAM = 3,
}
