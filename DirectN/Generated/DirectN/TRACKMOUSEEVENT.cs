#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-trackmouseevent
public partial struct TRACKMOUSEEVENT
{
    public uint cbSize;
    public TRACKMOUSEEVENT_FLAGS dwFlags;
    public HWND hwndTrack;
    public uint dwHoverTime;
}
