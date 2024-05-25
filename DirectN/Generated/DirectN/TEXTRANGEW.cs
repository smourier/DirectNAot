#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-textrangew
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct TEXTRANGEW
{
    public CHARRANGE chrg;
    public PWSTR lpstrText;
}
