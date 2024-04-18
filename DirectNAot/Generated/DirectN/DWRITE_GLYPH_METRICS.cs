namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_glyph_metrics
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_GLYPH_METRICS
{
    public int leftSideBearing;
    public uint advanceWidth;
    public int rightSideBearing;
    public int topSideBearing;
    public uint advanceHeight;
    public int bottomSideBearing;
    public int verticalOriginY;
}
