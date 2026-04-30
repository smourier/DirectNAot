#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-scrollbarinfo
public partial struct SCROLLBARINFO
{
    public uint cbSize;
    public RECT rcScrollBar;
    public int dxyLineButton;
    public int xyThumbTop;
    public int xyThumbBottom;
    public int reserved;
    public InlineArrayUInt32_6 rgstate;
}
