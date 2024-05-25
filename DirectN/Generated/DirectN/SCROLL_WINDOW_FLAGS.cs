#nullable enable
namespace DirectN;

[Flags]
public enum SCROLL_WINDOW_FLAGS : uint
{
    SW_SCROLLCHILDREN = 1,
    SW_INVALIDATE = 2,
    SW_ERASE = 4,
    SW_SMOOTHSCROLL = 16,
}
