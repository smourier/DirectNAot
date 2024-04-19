namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_process_input_stream_flags
[Flags]
public enum D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAGS
{
    D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_NONE = 0,
    D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_DISCONTINUITY = 1,
    D3D12_VIDEO_PROCESS_INPUT_STREAM_FLAG_FRAME_REPEAT = 2,
}
