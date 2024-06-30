#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-charformata
public partial struct CHARFORMATA
{
    public uint cbSize;
    public CFM_MASK dwMask;
    public CFE_EFFECTS dwEffects;
    public int yHeight;
    public int yOffset;
    public COLORREF crTextColor;
    public FONT_CHARSET bCharSet;
    public byte bPitchAndFamily;
    public InlineArrayFoundationCHAR_32 szFaceName;
}
