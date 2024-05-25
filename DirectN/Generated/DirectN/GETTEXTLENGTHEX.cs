#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-gettextlengthex
[StructLayout(LayoutKind.Sequential)]
public partial struct GETTEXTLENGTHEX
{
    public GETTEXTLENGTHEX_FLAGS flags;
    public uint codepage;
}
