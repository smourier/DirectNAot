#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-pointer_device_cursor_info
public partial struct POINTER_DEVICE_CURSOR_INFO
{
    public uint cursorId;
    public POINTER_DEVICE_CURSOR_TYPE cursor;
}
