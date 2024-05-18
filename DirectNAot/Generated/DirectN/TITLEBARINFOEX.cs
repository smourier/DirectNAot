#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-titlebarinfoex
[StructLayout(LayoutKind.Sequential)]
public partial struct TITLEBARINFOEX
{
    public uint cbSize;
    public RECT rcTitleBar;
    public InlineArrayUInt32_6 rgstate;
    public InlineArrayRECT_6 rgrect;
}
