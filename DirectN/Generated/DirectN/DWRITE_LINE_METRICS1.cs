#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ns-dwrite_3-dwrite_line_metrics1
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_LINE_METRICS1
{
    public DWRITE_LINE_METRICS Base;
    public float leadingBefore;
    public float leadingAfter;
}
