#nullable enable
namespace DirectN;

public partial struct D3D12_NODE_CPU_INPUT
{
    public uint EntrypointIndex;
    public uint NumRecords;
    public nint pRecords;
    public ulong RecordStrideInBytes;
}
