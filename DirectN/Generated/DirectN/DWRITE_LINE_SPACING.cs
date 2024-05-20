#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ns-dwrite_3-dwrite_line_spacing
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_LINE_SPACING
{
    public DWRITE_LINE_SPACING_METHOD method;
    public float height;
    public float baseline;
    public float leadingBefore;
    public DWRITE_FONT_LINE_GAP_USAGE fontLineGapUsage;
}
