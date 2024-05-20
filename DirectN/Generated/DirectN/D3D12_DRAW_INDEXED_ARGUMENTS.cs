#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_draw_indexed_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DRAW_INDEXED_ARGUMENTS
{
    public uint IndexCountPerInstance;
    public uint InstanceCount;
    public uint StartIndexLocation;
    public int BaseVertexLocation;
    public uint StartInstanceLocation;
}
