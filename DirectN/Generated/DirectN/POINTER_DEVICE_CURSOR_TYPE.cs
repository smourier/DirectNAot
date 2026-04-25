#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-pointer_device_cursor_type
public enum POINTER_DEVICE_CURSOR_TYPE
{
    POINTER_DEVICE_CURSOR_TYPE_UNKNOWN = 0,
    POINTER_DEVICE_CURSOR_TYPE_TIP = 1,
    POINTER_DEVICE_CURSOR_TYPE_ERASER = 2,
    POINTER_DEVICE_CURSOR_TYPE_MAX = -1,
}
