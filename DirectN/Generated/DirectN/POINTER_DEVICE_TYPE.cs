#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-pointer_device_type
public enum POINTER_DEVICE_TYPE
{
    POINTER_DEVICE_TYPE_INTEGRATED_PEN = 1,
    POINTER_DEVICE_TYPE_EXTERNAL_PEN = 2,
    POINTER_DEVICE_TYPE_TOUCH = 3,
    POINTER_DEVICE_TYPE_TOUCH_PAD = 4,
    POINTER_DEVICE_TYPE_MAX = -1,
}
