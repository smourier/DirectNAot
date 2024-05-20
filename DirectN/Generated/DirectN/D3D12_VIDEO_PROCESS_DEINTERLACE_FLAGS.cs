#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_process_deinterlace_flags
[Flags]
public enum D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS : uint
{
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE = 0,
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB = 1,
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM = 2147483648,
}
