﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_luma_key
public partial struct D3D12_VIDEO_PROCESS_LUMA_KEY
{
    public BOOL Enable;
    public float Lower;
    public float Upper;
}
