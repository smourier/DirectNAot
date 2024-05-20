#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_compute_pipeline_state_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_COMPUTE_PIPELINE_STATE_DESC
{
    public nint pRootSignature;
    public D3D12_SHADER_BYTECODE CS;
    public uint NodeMask;
    public D3D12_CACHED_PIPELINE_STATE CachedPSO;
    public D3D12_PIPELINE_STATE_FLAGS Flags;
}
