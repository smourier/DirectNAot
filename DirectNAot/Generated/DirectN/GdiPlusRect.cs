namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.foundation/ns-windows-foundation-rect
[StructLayout(LayoutKind.Sequential)]
public partial struct GdiPlusRect
{
    public int X;
    public int Y;
    public int Width;
    public int Height;
}
