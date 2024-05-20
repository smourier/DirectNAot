#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_NODE_CPU_INPUT
{
    public uint EntrypointIndex;
    public uint NumRecords;
    public nint pRecords;
    public ulong RecordStrideInBytes;
}
