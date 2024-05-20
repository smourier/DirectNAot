﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_alpha_blending
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_PROCESS_ALPHA_BLENDING
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public float Alpha;
}