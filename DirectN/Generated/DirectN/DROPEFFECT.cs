#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/com/dropeffect-constants
[Flags]
public enum DROPEFFECT : uint
{
    DROPEFFECT_NONE = 0,
    DROPEFFECT_COPY = 1,
    DROPEFFECT_MOVE = 2,
    DROPEFFECT_LINK = 4,
    DROPEFFECT_SCROLL = 2147483648,
}
