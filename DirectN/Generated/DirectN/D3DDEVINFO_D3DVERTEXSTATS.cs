#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevinfo-d3dvertexstats
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVINFO_D3DVERTEXSTATS
{
    public uint NumRenderedTriangles;
    public uint NumExtraClippingTriangles;
}
