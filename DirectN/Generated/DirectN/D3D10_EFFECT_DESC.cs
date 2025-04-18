﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_effect_desc
public partial struct D3D10_EFFECT_DESC
{
    public BOOL IsChildEffect;
    public uint ConstantBuffers;
    public uint SharedConstantBuffers;
    public uint GlobalVariables;
    public uint SharedGlobalVariables;
    public uint Techniques;
}
