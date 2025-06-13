#nullable enable
namespace DirectN;

[Flags]
public enum QUEUE_STATUS_FLAGS : uint
{
    QS_ALLEVENTS = 1215,
    QS_ALLINPUT = 1279,
    QS_ALLPOSTMESSAGE = 256,
    QS_HOTKEY = 128,
    QS_INPUT = 1031,
    QS_KEY = 1,
    QS_MOUSE = 6,
    QS_MOUSEBUTTON = 4,
    QS_MOUSEMOVE = 2,
    QS_PAINT = 32,
    QS_POSTMESSAGE = 8,
    QS_RAWINPUT = 1024,
    QS_SENDMESSAGE = 64,
    QS_TIMER = 16,
}
