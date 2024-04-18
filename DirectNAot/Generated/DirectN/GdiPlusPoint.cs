namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.foundation/ns-windows-foundation-point
[StructLayout(LayoutKind.Sequential)]
public partial struct GdiPlusPoint
{
    public int X;
    public int Y;
}
