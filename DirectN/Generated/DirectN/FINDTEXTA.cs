#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-findtexta
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct FINDTEXTA
{
    public CHARRANGE chrg;
    public PSTR lpstrText;
}
