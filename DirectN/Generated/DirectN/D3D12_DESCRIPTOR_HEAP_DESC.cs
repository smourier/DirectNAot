﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_descriptor_heap_desc
public partial struct D3D12_DESCRIPTOR_HEAP_DESC
{
    public D3D12_DESCRIPTOR_HEAP_TYPE Type;
    public uint NumDescriptors;
    public D3D12_DESCRIPTOR_HEAP_FLAGS Flags;
    public uint NodeMask;
}
