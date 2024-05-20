#nullable enable
namespace DirectN;

[Flags]
public enum ADVISE_TYPE
{
    ADVISE_NONE = 0,
    ADVISE_CLIPPING = 1,
    ADVISE_PALETTE = 2,
    ADVISE_COLORKEY = 4,
    ADVISE_POSITION = 8,
    ADVISE_DISPLAY_CHANGE = 16,
}
