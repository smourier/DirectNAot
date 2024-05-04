#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DISPATCH_MESH_ARGUMENTS
{
    public uint ThreadGroupCountX;
    public uint ThreadGroupCountY;
    public uint ThreadGroupCountZ;
}
