﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_format
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_FORMAT
{
    public DXGI_FORMAT Format;
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
}
