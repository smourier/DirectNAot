#nullable enable
namespace DirectN;

[Flags]
public enum TEXT_ALIGN_OPTIONS : uint
{
    TA_NOUPDATECP = 0,
    TA_UPDATECP = 1,
    TA_LEFT = 0,
    TA_RIGHT = 2,
    TA_CENTER = 6,
    TA_TOP = 0,
    TA_BOTTOM = 8,
    TA_BASELINE = 24,
    TA_RTLREADING = 256,
    TA_MASK = 287,
    VTA_BASELINE = 24,
    VTA_LEFT = 8,
    VTA_RIGHT = 0,
    VTA_CENTER = 6,
    VTA_BOTTOM = 2,
    VTA_TOP = 0,
}
