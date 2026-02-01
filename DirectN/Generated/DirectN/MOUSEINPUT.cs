#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-mouseinput
public partial struct MOUSEINPUT
{
    public int dx;
    public int dy;
    public uint mouseData;
    public MOUSE_EVENT_FLAGS dwFlags;
    public uint time;
    public nuint dwExtraInfo;
}
