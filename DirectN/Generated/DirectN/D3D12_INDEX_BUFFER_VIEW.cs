#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_index_buffer_view
public partial struct D3D12_INDEX_BUFFER_VIEW
{
    public ulong BufferLocation;
    public uint SizeInBytes;
    public DXGI_FORMAT Format;
}
