﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_var_info
public partial struct D3D10_SHADER_DEBUG_VAR_INFO
{
    public uint TokenId;
    public D3D_SHADER_VARIABLE_TYPE Type;
    public uint Register;
    public uint Component;
    public uint ScopeVar;
    public uint ScopeVarOffset;
}
