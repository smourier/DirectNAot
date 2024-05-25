#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-hyphresult
[StructLayout(LayoutKind.Sequential)]
public partial struct HYPHRESULT
{
    public KHYPH khyph;
    public int ichHyph;
    public char chHyph;
}
