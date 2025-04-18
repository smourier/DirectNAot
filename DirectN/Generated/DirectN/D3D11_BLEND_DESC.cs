﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_blend_desc
public partial struct D3D11_BLEND_DESC
{
    public BOOL AlphaToCoverageEnable;
    public BOOL IndependentBlendEnable;
    public InlineArrayD3D11_RENDER_TARGET_BLEND_DESC_8 RenderTarget;
}
