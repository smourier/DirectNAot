﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_mip_region
public partial struct D3D12_MIP_REGION
{
    public uint Width;
    public uint Height;
    public uint Depth;
}
