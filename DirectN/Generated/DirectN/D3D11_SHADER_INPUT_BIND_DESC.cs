﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/ns-d3d11shader-d3d11_shader_input_bind_desc
public partial struct D3D11_SHADER_INPUT_BIND_DESC
{
    public PSTR Name;
    public D3D_SHADER_INPUT_TYPE Type;
    public uint BindPoint;
    public uint BindCount;
    public uint uFlags;
    public D3D_RESOURCE_RETURN_TYPE ReturnType;
    public D3D_SRV_DIMENSION Dimension;
    public uint NumSamples;
}
