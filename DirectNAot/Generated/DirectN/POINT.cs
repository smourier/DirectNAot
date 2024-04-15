namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windef/ns-windef-point
[StructLayout(LayoutKind.Sequential)]
public partial struct POINT
{
    public int x;
    public int y;
}
