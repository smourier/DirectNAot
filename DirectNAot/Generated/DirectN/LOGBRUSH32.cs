namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-logbrush32
[StructLayout(LayoutKind.Sequential)]
public partial struct LOGBRUSH32
{
    public BRUSH_STYLE lbStyle;
    public COLORREF lbColor;
    public uint lbHatch;
}
