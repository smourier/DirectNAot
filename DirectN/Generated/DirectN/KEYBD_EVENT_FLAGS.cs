#nullable enable
namespace DirectN;

[Flags]
public enum KEYBD_EVENT_FLAGS : uint
{
    KEYEVENTF_EXTENDEDKEY = 1,
    KEYEVENTF_KEYUP = 2,
    KEYEVENTF_SCANCODE = 8,
    KEYEVENTF_UNICODE = 4,
}
