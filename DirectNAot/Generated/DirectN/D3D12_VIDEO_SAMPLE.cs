﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_sample
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_SAMPLE
{
    public uint Width;
    public uint Height;
    public D3D12_VIDEO_FORMAT Format;
}