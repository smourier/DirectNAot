﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_render_target_blend_desc
public partial struct D3D12_RENDER_TARGET_BLEND_DESC
{
    public BOOL BlendEnable;
    public BOOL LogicOpEnable;
    public D3D12_BLEND SrcBlend;
    public D3D12_BLEND DestBlend;
    public D3D12_BLEND_OP BlendOp;
    public D3D12_BLEND SrcBlendAlpha;
    public D3D12_BLEND DestBlendAlpha;
    public D3D12_BLEND_OP BlendOpAlpha;
    public D3D12_LOGIC_OP LogicOp;
    public byte RenderTargetWriteMask;
}
