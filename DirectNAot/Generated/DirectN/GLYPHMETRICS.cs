namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-glyphmetrics
[StructLayout(LayoutKind.Sequential)]
public partial struct GLYPHMETRICS
{
    public uint gmBlackBoxX;
    public uint gmBlackBoxY;
    public nint gmptGlyphOrigin;
    public short gmCellIncX;
    public short gmCellIncY;
}
