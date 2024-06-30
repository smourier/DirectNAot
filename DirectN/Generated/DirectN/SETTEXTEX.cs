#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-settextex
public partial struct SETTEXTEX
{
    public uint flags;
    public uint codepage;
}
