namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_decode_conversion_support_flags
[Flags]
public enum D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAGS
{
    D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAG_NONE = 0,
    D3D12_VIDEO_DECODE_CONVERSION_SUPPORT_FLAG_SUPPORTED = 1,
}
