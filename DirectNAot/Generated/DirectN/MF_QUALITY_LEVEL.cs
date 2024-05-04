#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mf_quality_level
public enum MF_QUALITY_LEVEL
{
    MF_QUALITY_NORMAL = 0,
    MF_QUALITY_NORMAL_MINUS_1 = 1,
    MF_QUALITY_NORMAL_MINUS_2 = 2,
    MF_QUALITY_NORMAL_MINUS_3 = 3,
    MF_QUALITY_NORMAL_MINUS_4 = 4,
    MF_QUALITY_NORMAL_MINUS_5 = 5,
    MF_NUM_QUALITY_LEVELS = 6,
}
