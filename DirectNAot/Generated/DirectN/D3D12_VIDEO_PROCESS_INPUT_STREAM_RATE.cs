﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_input_stream_rate
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_PROCESS_INPUT_STREAM_RATE
{
    public uint OutputIndex;
    public uint InputFrameOrField;
}