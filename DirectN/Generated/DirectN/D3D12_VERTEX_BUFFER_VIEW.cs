#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_vertex_buffer_view
public partial struct D3D12_VERTEX_BUFFER_VIEW
{
    public ulong BufferLocation;
    public uint SizeInBytes;
    public uint StrideInBytes;
}
