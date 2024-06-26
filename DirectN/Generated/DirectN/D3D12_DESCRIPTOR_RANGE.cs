﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_descriptor_range
public partial struct D3D12_DESCRIPTOR_RANGE
{
    public D3D12_DESCRIPTOR_RANGE_TYPE RangeType;
    public uint NumDescriptors;
    public uint BaseShaderRegister;
    public uint RegisterSpace;
    public uint OffsetInDescriptorsFromTableStart;
}
