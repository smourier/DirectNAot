#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ne-dwrite_1-dwrite_baseline
public enum DWRITE_BASELINE
{
    DWRITE_BASELINE_DEFAULT = 0,
    DWRITE_BASELINE_ROMAN = 1,
    DWRITE_BASELINE_CENTRAL = 2,
    DWRITE_BASELINE_MATH = 3,
    DWRITE_BASELINE_HANGING = 4,
    DWRITE_BASELINE_IDEOGRAPHIC_BOTTOM = 5,
    DWRITE_BASELINE_IDEOGRAPHIC_TOP = 6,
    DWRITE_BASELINE_MINIMUM = 7,
    DWRITE_BASELINE_MAXIMUM = 8,
}
