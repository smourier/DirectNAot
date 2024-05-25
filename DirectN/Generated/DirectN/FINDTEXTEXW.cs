#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-findtextexw
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct FINDTEXTEXW
{
    public CHARRANGE chrg;
    public PWSTR lpstrText;
    public CHARRANGE chrgText;
}
