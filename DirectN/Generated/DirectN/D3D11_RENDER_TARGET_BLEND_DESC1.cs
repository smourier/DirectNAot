﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/ns-d3d11_1-d3d11_render_target_blend_desc1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_RENDER_TARGET_BLEND_DESC1
{
    [MarshalAs(UnmanagedType.U4)]
    public bool BlendEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool LogicOpEnable;
    public D3D11_BLEND SrcBlend;
    public D3D11_BLEND DestBlend;
    public D3D11_BLEND_OP BlendOp;
    public D3D11_BLEND SrcBlendAlpha;
    public D3D11_BLEND DestBlendAlpha;
    public D3D11_BLEND_OP BlendOpAlpha;
    public D3D11_LOGIC_OP LogicOp;
    public byte RenderTargetWriteMask;
}