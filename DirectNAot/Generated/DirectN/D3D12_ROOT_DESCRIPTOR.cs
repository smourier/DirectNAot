﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_root_descriptor
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_ROOT_DESCRIPTOR
{
    public uint ShaderRegister;
    public uint RegisterSpace;
}
