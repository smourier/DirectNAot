#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_MULTI_NODE_CPU_INPUT
{
    public uint NumNodeInputs;
    public nint pNodeInputs;
    public ulong NodeInputStrideInBytes;
}
