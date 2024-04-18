namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-newtextmetrica
[StructLayout(LayoutKind.Sequential)]
public partial struct NEWTEXTMETRICA
{
    public int tmHeight;
    public int tmAscent;
    public int tmDescent;
    public int tmInternalLeading;
    public int tmExternalLeading;
    public int tmAveCharWidth;
    public int tmMaxCharWidth;
    public int tmWeight;
    public int tmOverhang;
    public int tmDigitizedAspectX;
    public int tmDigitizedAspectY;
    public byte tmFirstChar;
    public byte tmLastChar;
    public byte tmDefaultChar;
    public byte tmBreakChar;
    public byte tmItalic;
    public byte tmUnderlined;
    public byte tmStruckOut;
    public TMPF_FLAGS tmPitchAndFamily;
    public byte tmCharSet;
    public uint ntmFlags;
    public uint ntmSizeEM;
    public uint ntmCellHeight;
    public uint ntmAvgWidth;
}
