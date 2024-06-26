﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_barrier_subresource_range
public partial struct D3D12_BARRIER_SUBRESOURCE_RANGE
{
    public uint IndexOrFirstMipLevel;
    public uint NumMipLevels;
    public uint FirstArraySlice;
    public uint NumArraySlices;
    public uint FirstPlane;
    public uint NumPlanes;
}
