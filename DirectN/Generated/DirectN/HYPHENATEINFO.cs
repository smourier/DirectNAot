#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-hyphenateinfo
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct HYPHENATEINFO
{
    public short cbSize;
    public short dxHyphenateZone;
    public nint pfnHyphenate;
}
