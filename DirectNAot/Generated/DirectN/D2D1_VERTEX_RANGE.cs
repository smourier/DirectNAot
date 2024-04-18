namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_vertex_range
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_VERTEX_RANGE
{
    public uint startVertex;
    public uint vertexCount;
}
