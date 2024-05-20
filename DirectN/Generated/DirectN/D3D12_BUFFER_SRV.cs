﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_buffer_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_BUFFER_SRV
{
    public ulong FirstElement;
    public uint NumElements;
    public uint StructureByteStride;
    public D3D12_BUFFER_SRV_FLAGS Flags;
}
