#nullable enable
namespace DirectN;

public partial struct D3D12_NODE_GPU_INPUT
{
    public uint EntrypointIndex;
    public uint NumRecords;
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE Records;
}
