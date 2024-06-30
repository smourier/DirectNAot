#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_vertex_buffer_properties
public partial struct D2D1_VERTEX_BUFFER_PROPERTIES
{
    public uint inputCount;
    public D2D1_VERTEX_USAGE usage;
    public nint data;
    public uint byteWidth;
}
