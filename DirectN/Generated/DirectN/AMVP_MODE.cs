#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vptype/ne-vptype-amvp_mode
public enum AMVP_MODE
{
    AMVP_MODE_WEAVE = 0,
    AMVP_MODE_BOBINTERLEAVED = 1,
    AMVP_MODE_BOBNONINTERLEAVED = 2,
    AMVP_MODE_SKIPEVEN = 3,
    AMVP_MODE_SKIPODD = 4,
}
