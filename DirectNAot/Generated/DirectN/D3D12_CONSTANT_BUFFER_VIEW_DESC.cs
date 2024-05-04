#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_constant_buffer_view_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_CONSTANT_BUFFER_VIEW_DESC
{
    public ulong BufferLocation;
    public uint SizeInBytes;
}
