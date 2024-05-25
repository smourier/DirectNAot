#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/richedit/ns-richedit-getcontextmenuex
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct GETCONTEXTMENUEX
{
    public CHARRANGE chrg;
    public uint dwFlags;
    public POINT pt;
    public nint pvReserved;
}
