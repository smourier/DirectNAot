namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windef/ns-windef-pointl
[StructLayout(LayoutKind.Sequential)]
public partial struct POINTL
{
    public int x;
    public int y;
}
