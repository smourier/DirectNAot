﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_picture_resolution_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC
{
    public uint Width;
    public uint Height;
}
