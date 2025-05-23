﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10_1shader/ns-d3d10_1shader-d3d10_shader_debug_outputvar
public partial struct D3D10_SHADER_DEBUG_OUTPUTVAR
{
    public uint Var;
    public uint uValueMin;
    public uint uValueMax;
    public int iValueMin;
    public int iValueMax;
    public float fValueMin;
    public float fValueMax;
    public BOOL bNaNPossible;
    public BOOL bInfPossible;
}
