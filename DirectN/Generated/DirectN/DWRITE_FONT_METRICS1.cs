#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ns-dwrite_1-dwrite_font_metrics1
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_FONT_METRICS1
{
    public DWRITE_FONT_METRICS Base;
    public short glyphBoxLeft;
    public short glyphBoxTop;
    public short glyphBoxRight;
    public short glyphBoxBottom;
    public short subscriptPositionX;
    public short subscriptPositionY;
    public short subscriptSizeX;
    public short subscriptSizeY;
    public short superscriptPositionX;
    public short superscriptPositionY;
    public short superscriptSizeX;
    public short superscriptSizeY;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool hasTypographicMetrics;
}
