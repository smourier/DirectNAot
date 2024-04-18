namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-logpen
[StructLayout(LayoutKind.Sequential)]
public partial struct LOGPEN
{
    public uint lopnStyle;
    public nint lopnWidth;
    public COLORREF lopnColor;
}
