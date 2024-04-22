namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-drawpatrect
[StructLayout(LayoutKind.Sequential)]
public partial struct DRAWPATRECT
{
    public nint ptPosition;
    public nint ptSize;
    public ushort wStyle;
    public ushort wPattern;
}
