#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-gettextex
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct GETTEXTEX
{
    public uint cb;
    public GETTEXTEX_FLAGS flags;
    public uint codepage;
    public PSTR lpDefaultChar;
    
    [MarshalAs(UnmanagedType.U4)]
    public nint lpUsedDefChar;
}
