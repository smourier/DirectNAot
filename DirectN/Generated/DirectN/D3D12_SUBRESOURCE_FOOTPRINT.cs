﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_subresource_footprint
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_SUBRESOURCE_FOOTPRINT
{
    public DXGI_FORMAT Format;
    public uint Width;
    public uint Height;
    public uint Depth;
    public uint RowPitch;
}