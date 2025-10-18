#nullable enable
namespace DirectN;

[Flags]
public enum TOOLTIP_FLAGS : uint
{
    TTF_IDISHWND = 1,
    TTF_CENTERTIP = 2,
    TTF_RTLREADING = 4,
    TTF_SUBCLASS = 16,
    TTF_TRACK = 32,
    TTF_ABSOLUTE = 128,
    TTF_TRANSPARENT = 256,
    TTF_PARSELINKS = 4096,
    TTF_DI_SETITEM = 32768,
}
