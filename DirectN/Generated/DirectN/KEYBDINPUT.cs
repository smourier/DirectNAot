#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-keybdinput
public partial struct KEYBDINPUT
{
    public VIRTUAL_KEY wVk;
    public ushort wScan;
    public KEYBD_EVENT_FLAGS dwFlags;
    public uint time;
    public nuint dwExtraInfo;
}
