#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_glyph_run
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_GLYPH_RUN
{
    public nint fontFace;
    public float fontEmSize;
    public uint glyphCount;
    public nint glyphIndices;
    public nint glyphAdvances;
    public nint glyphOffsets;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool isSideways;
    public uint bidiLevel;
}
