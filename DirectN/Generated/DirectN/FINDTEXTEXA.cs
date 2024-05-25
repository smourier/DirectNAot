#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-findtextexa
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct FINDTEXTEXA
{
    public CHARRANGE chrg;
    public PSTR lpstrText;
    public CHARRANGE chrgText;
}
