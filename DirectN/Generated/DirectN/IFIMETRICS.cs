#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-ifimetrics
[StructLayout(LayoutKind.Sequential)]
public partial struct IFIMETRICS
{
    public uint cjThis;
    public uint cjIfiExtra;
    public int dpwszFamilyName;
    public int dpwszStyleName;
    public int dpwszFaceName;
    public int dpwszUniqueName;
    public int dpFontSim;
    public int lEmbedId;
    public int lItalicAngle;
    public int lCharBias;
    public int dpCharSets;
    public byte jWinCharSet;
    public byte jWinPitchAndFamily;
    public ushort usWinWeight;
    public uint flInfo;
    public ushort fsSelection;
    public ushort fsType;
    public short fwdUnitsPerEm;
    public short fwdLowestPPEm;
    public short fwdWinAscender;
    public short fwdWinDescender;
    public short fwdMacAscender;
    public short fwdMacDescender;
    public short fwdMacLineGap;
    public short fwdTypoAscender;
    public short fwdTypoDescender;
    public short fwdTypoLineGap;
    public short fwdAveCharWidth;
    public short fwdMaxCharInc;
    public short fwdCapHeight;
    public short fwdXHeight;
    public short fwdSubscriptXSize;
    public short fwdSubscriptYSize;
    public short fwdSubscriptXOffset;
    public short fwdSubscriptYOffset;
    public short fwdSuperscriptXSize;
    public short fwdSuperscriptYSize;
    public short fwdSuperscriptXOffset;
    public short fwdSuperscriptYOffset;
    public short fwdUnderscoreSize;
    public short fwdUnderscorePosition;
    public short fwdStrikeoutSize;
    public short fwdStrikeoutPosition;
    public byte chFirstChar;
    public byte chLastChar;
    public byte chDefaultChar;
    public byte chBreakChar;
    public char wcFirstChar;
    public char wcLastChar;
    public char wcDefaultChar;
    public char wcBreakChar;
    public POINTL ptlBaseline;
    public POINTL ptlAspect;
    public POINTL ptlCaret;
    public RECTL rclFontBox;
    public InlineArrayByte_4 achVendId;
    public uint cKerningPairs;
    public uint ulPanoseCulture;
    public PANOSE panose;
    public nint Align;
}
