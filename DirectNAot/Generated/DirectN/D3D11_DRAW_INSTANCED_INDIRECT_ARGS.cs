namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_draw_instanced_indirect_args
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_DRAW_INSTANCED_INDIRECT_ARGS
{
    public uint VertexCountPerInstance;
    public uint InstanceCount;
    public uint StartVertexLocation;
    public uint StartInstanceLocation;
}
