namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_draw_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DRAW_ARGUMENTS
{
    public uint VertexCountPerInstance;
    public uint InstanceCount;
    public uint StartVertexLocation;
    public uint StartInstanceLocation;
}
