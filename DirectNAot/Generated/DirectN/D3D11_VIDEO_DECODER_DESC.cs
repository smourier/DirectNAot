﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_decoder_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_VIDEO_DECODER_DESC
{
    public Guid Guid;
    public uint SampleWidth;
    public uint SampleHeight;
    public DXGI_FORMAT OutputFormat;
}
