#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-textrangea
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct TEXTRANGEA
{
    public CHARRANGE chrg;
    public PSTR lpstrText;
}
