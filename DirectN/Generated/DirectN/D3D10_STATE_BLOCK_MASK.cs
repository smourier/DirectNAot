﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_state_block_mask
public partial struct D3D10_STATE_BLOCK_MASK
{
    public byte VS;
    public InlineArrayByte_2 VSSamplers;
    public InlineArrayByte_16 VSShaderResources;
    public InlineArrayByte_2 VSConstantBuffers;
    public byte GS;
    public InlineArrayByte_2 GSSamplers;
    public InlineArrayByte_16 GSShaderResources;
    public InlineArrayByte_2 GSConstantBuffers;
    public byte PS;
    public InlineArrayByte_2 PSSamplers;
    public InlineArrayByte_16 PSShaderResources;
    public InlineArrayByte_2 PSConstantBuffers;
    public InlineArrayByte_2 IAVertexBuffers;
    public byte IAIndexBuffer;
    public byte IAInputLayout;
    public byte IAPrimitiveTopology;
    public byte OMRenderTargets;
    public byte OMDepthStencilState;
    public byte OMBlendState;
    public byte RSViewports;
    public byte RSScissorRects;
    public byte RSRasterizerState;
    public byte SOBuffers;
    public byte Predication;
}
