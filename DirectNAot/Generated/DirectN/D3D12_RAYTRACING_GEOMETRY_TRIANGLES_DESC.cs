namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_geometry_triangles_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC
{
    public ulong Transform3x4;
    public DXGI_FORMAT IndexFormat;
    public DXGI_FORMAT VertexFormat;
    public uint IndexCount;
    public uint VertexCount;
    public ulong IndexBuffer;
    public D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE VertexBuffer;
}
