namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windef/ns-windef-points
[StructLayout(LayoutKind.Sequential)]
public partial struct POINTS
{
    public short x;
    public short y;
}
