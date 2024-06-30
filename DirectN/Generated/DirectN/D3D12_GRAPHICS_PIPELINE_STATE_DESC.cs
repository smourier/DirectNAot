#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_graphics_pipeline_state_desc
public partial struct D3D12_GRAPHICS_PIPELINE_STATE_DESC
{
    public nint pRootSignature;
    public D3D12_SHADER_BYTECODE VS;
    public D3D12_SHADER_BYTECODE PS;
    public D3D12_SHADER_BYTECODE DS;
    public D3D12_SHADER_BYTECODE HS;
    public D3D12_SHADER_BYTECODE GS;
    public D3D12_STREAM_OUTPUT_DESC StreamOutput;
    public D3D12_BLEND_DESC BlendState;
    public uint SampleMask;
    public D3D12_RASTERIZER_DESC RasterizerState;
    public D3D12_DEPTH_STENCIL_DESC DepthStencilState;
    public D3D12_INPUT_LAYOUT_DESC InputLayout;
    public D3D12_INDEX_BUFFER_STRIP_CUT_VALUE IBStripCutValue;
    public D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType;
    public uint NumRenderTargets;
    public InlineArrayDXGI_FORMAT_8 RTVFormats;
    public DXGI_FORMAT DSVFormat;
    public DXGI_SAMPLE_DESC SampleDesc;
    public uint NodeMask;
    public D3D12_CACHED_PIPELINE_STATE CachedPSO;
    public D3D12_PIPELINE_STATE_FLAGS Flags;
}
