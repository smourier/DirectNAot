#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_state_block_mask
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_STATE_BLOCK_MASK
{
    public byte VS;
    public InlineArrayByte2 VSSamplers;
    public InlineArrayByte16 VSShaderResources;
    public InlineArrayByte2 VSConstantBuffers;
    public byte GS;
    public InlineArrayByte2 GSSamplers;
    public InlineArrayByte16 GSShaderResources;
    public InlineArrayByte2 GSConstantBuffers;
    public byte PS;
    public InlineArrayByte2 PSSamplers;
    public InlineArrayByte16 PSShaderResources;
    public InlineArrayByte2 PSConstantBuffers;
    public InlineArrayByte2 IAVertexBuffers;
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
