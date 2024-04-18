namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shtypes/ns-shtypes-logfontw
[StructLayout(LayoutKind.Sequential)]
public partial struct LOGFONTW
{
    public int lfHeight;
    public int lfWidth;
    public int lfEscapement;
    public int lfOrientation;
    public int lfWeight;
    public byte lfItalic;
    public byte lfUnderline;
    public byte lfStrikeOut;
    public FONT_CHARSET lfCharSet;
    public FONT_OUTPUT_PRECISION lfOutPrecision;
    public FONT_CLIP_PRECISION lfClipPrecision;
    public FONT_QUALITY lfQuality;
    public byte lfPitchAndFamily;
    public InlineArraySystemChar32 lfFaceName;
}
