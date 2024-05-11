#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_MULTI_NODE_GPU_INPUT
{
    public uint NumNodeInputs;
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE NodeInputs;
}
