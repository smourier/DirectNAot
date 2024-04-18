namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_glyph_offset
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_GLYPH_OFFSET
{
    public float advanceOffset;
    public float ascenderOffset;
}
