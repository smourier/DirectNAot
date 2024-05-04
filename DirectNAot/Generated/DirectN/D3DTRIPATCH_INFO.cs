#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dtripatch-info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DTRIPATCH_INFO
{
    public uint StartVertexOffset;
    public uint NumVertices;
    public D3DBASISTYPE Basis;
    public D3DDEGREETYPE Degree;
}
