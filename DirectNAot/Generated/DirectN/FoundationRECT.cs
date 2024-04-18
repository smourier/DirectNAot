namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windef/ns-windef-rect
[StructLayout(LayoutKind.Sequential)]
public partial struct FoundationRECT
{
    public int left;
    public int top;
    public int right;
    public int bottom;
}
