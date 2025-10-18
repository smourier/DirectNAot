#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/commctrl/ns-commctrl-ttgettitle
public partial struct TTGETTITLE
{
    public uint dwSize;
    public uint uTitleBitmap;
    public uint cch;
    public PWSTR pszTitle;
}
