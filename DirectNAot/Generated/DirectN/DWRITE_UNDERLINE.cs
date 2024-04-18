namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_underline
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_UNDERLINE
{
    public float width;
    public float thickness;
    public float offset;
    public float runHeight;
    public DWRITE_READING_DIRECTION readingDirection;
    public DWRITE_FLOW_DIRECTION flowDirection;
    public PWSTR localeName;
    public DWRITE_MEASURING_MODE measuringMode;
}
