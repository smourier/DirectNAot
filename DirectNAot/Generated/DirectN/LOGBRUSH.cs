namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-logbrush
[StructLayout(LayoutKind.Sequential)]
public partial struct LOGBRUSH
{
    public BRUSH_STYLE lbStyle;
    public COLORREF lbColor;
    public nuint lbHatch;
}
