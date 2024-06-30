﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_resource_aliasing_barrier
public partial struct D3D12_RESOURCE_ALIASING_BARRIER
{
    public nint pResourceBefore;
    public nint pResourceAfter;
}
