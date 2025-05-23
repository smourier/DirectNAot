﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_depth_stencil_desc
public partial struct D3D12_DEPTH_STENCIL_DESC
{
    public BOOL DepthEnable;
    public D3D12_DEPTH_WRITE_MASK DepthWriteMask;
    public D3D12_COMPARISON_FUNC DepthFunc;
    public BOOL StencilEnable;
    public byte StencilReadMask;
    public byte StencilWriteMask;
    public D3D12_DEPTH_STENCILOP_DESC FrontFace;
    public D3D12_DEPTH_STENCILOP_DESC BackFace;
}
