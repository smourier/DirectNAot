#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-paraformat2
public partial struct PARAFORMAT2
{
    public PARAFORMAT Base;
    public int dySpaceBefore;
    public int dySpaceAfter;
    public int dyLineSpacing;
    public short sStyle;
    public byte bLineSpacingRule;
    public byte bOutlineLevel;
    public ushort wShadingWeight;
    public PARAFORMAT_SHADING_STYLE wShadingStyle;
    public ushort wNumberingStart;
    public PARAFORMAT_NUMBERING_STYLE wNumberingStyle;
    public ushort wNumberingTab;
    public ushort wBorderSpace;
    public ushort wBorderWidth;
    public PARAFORMAT_BORDERS wBorders;
}
