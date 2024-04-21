﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_blend_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_BLEND_DESC
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AlphaToCoverageEnable;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IndependentBlendEnable;
    public InlineArrayD3D12_RENDER_TARGET_BLEND_DESC8 RenderTarget;
}