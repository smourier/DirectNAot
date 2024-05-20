#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3drectpatch-info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DRECTPATCH_INFO
{
    public uint StartVertexOffsetWidth;
    public uint StartVertexOffsetHeight;
    public uint Width;
    public uint Height;
    public uint Stride;
    public D3DBASISTYPE Basis;
    public D3DDEGREETYPE Degree;
}
