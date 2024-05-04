#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3drect
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DRECT
{
    public int x1;
    public int y1;
    public int x2;
    public int y2;
}
