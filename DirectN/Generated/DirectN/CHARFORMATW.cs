#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-charformatw
[StructLayout(LayoutKind.Sequential)]
public partial struct CHARFORMATW
{
    public uint cbSize;
    public CFM_MASK dwMask;
    public CFE_EFFECTS dwEffects;
    public int yHeight;
    public int yOffset;
    public COLORREF crTextColor;
    public FONT_CHARSET bCharSet;
    public byte bPitchAndFamily;
    public InlineArraySystemChar_32 szFaceName;
}
