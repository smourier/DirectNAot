#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_NODE_ID
{
    public PWSTR Name;
    public uint ArrayIndex;
}
