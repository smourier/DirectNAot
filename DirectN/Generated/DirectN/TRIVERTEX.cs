#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-trivertex
public partial struct TRIVERTEX
{
    public int x;
    public int y;
    public ushort Red;
    public ushort Green;
    public ushort Blue;
    public ushort Alpha;
}
