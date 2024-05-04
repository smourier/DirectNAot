#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DSTATS
{
    public uint dwSize;
    public uint dwTrianglesDrawn;
    public uint dwLinesDrawn;
    public uint dwPointsDrawn;
    public uint dwSpansDrawn;
    public uint dwVerticesProcessed;
}
