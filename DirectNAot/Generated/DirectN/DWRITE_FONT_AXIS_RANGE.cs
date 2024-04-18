namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ns-dwrite_3-dwrite_font_axis_range
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_FONT_AXIS_RANGE
{
    public DWRITE_FONT_AXIS_TAG axisTag;
    public float minValue;
    public float maxValue;
}
