#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-panose
[StructLayout(LayoutKind.Sequential)]
public partial struct PANOSE
{
    public PAN_FAMILY_TYPE bFamilyType;
    public PAN_SERIF_STYLE bSerifStyle;
    public PAN_WEIGHT bWeight;
    public PAN_PROPORTION bProportion;
    public PAN_CONTRAST bContrast;
    public PAN_STROKE_VARIATION bStrokeVariation;
    public PAN_ARM_STYLE bArmStyle;
    public PAN_LETT_FORM bLetterform;
    public PAN_MIDLINE bMidline;
    public PAN_XHEIGHT bXHeight;
}
