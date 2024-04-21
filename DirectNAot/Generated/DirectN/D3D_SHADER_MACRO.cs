﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcommon/ns-d3dcommon-d3d_shader_macro
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D_SHADER_MACRO
{
    public PSTR Name;
    public PSTR Definition;
}