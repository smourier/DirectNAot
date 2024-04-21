﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_decode_conversion_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public nint pReferenceTexture2D;
    public uint ReferenceSubresource;
    public DXGI_COLOR_SPACE_TYPE OutputColorSpace;
    public DXGI_COLOR_SPACE_TYPE DecodeColorSpace;
}