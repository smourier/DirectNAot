﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_custom_rate
public partial struct D3D11_VIDEO_PROCESSOR_CUSTOM_RATE
{
    public DXGI_RATIONAL CustomRate;
    public uint OutputFrames;
    public BOOL InputInterlaced;
    public uint InputFramesOrFields;
}
