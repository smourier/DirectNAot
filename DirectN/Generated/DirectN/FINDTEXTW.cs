#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-findtextw
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct FINDTEXTW
{
    public CHARRANGE chrg;
    public PWSTR lpstrText;
}
