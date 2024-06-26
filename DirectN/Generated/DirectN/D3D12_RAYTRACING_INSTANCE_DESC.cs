﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_instance_desc
public partial struct D3D12_RAYTRACING_INSTANCE_DESC
{
    public InlineArraySingle_12 Transform;
    public uint _bitfield1;
    public uint _bitfield2;
    public ulong AccelerationStructure;
}
