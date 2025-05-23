﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_blend_desc
public partial struct D3D12_BLEND_DESC
{
    public BOOL AlphaToCoverageEnable;
    public BOOL IndependentBlendEnable;
    public InlineArrayD3D12_RENDER_TARGET_BLEND_DESC_8 RenderTarget;
}
