namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ns-xpsobjectmodel-xps_glyph_index
[StructLayout(LayoutKind.Sequential)]
public partial struct XPS_GLYPH_INDEX
{
    public int index;
    public float advanceWidth;
    public float horizontalOffset;
    public float verticalOffset;
}
