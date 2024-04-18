namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-outlinetextmetricw
[StructLayout(LayoutKind.Sequential)]
public partial struct OUTLINETEXTMETRICW
{
    public uint otmSize;
    public TEXTMETRICW otmTextMetrics;
    public byte otmFiller;
    public PANOSE otmPanoseNumber;
    public uint otmfsSelection;
    public uint otmfsType;
    public int otmsCharSlopeRise;
    public int otmsCharSlopeRun;
    public int otmItalicAngle;
    public uint otmEMSquare;
    public int otmAscent;
    public int otmDescent;
    public uint otmLineGap;
    public uint otmsCapEmHeight;
    public uint otmsXHeight;
    public FoundationRECT otmrcFontBox;
    public int otmMacAscent;
    public int otmMacDescent;
    public uint otmMacLineGap;
    public uint otmusMinimumPPEM;
    public nint otmptSubscriptSize;
    public nint otmptSubscriptOffset;
    public nint otmptSuperscriptSize;
    public nint otmptSuperscriptOffset;
    public uint otmsStrikeoutSize;
    public int otmsStrikeoutPosition;
    public int otmsUnderscoreSize;
    public int otmsUnderscorePosition;
    public PSTR otmpFamilyName;
    public PSTR otmpFaceName;
    public PSTR otmpStyleName;
    public PSTR otmpFullName;
}
