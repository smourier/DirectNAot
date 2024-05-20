#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_filter
public enum DXVAHD_FILTER
{
    DXVAHD_FILTER_BRIGHTNESS = 0,
    DXVAHD_FILTER_CONTRAST = 1,
    DXVAHD_FILTER_HUE = 2,
    DXVAHD_FILTER_SATURATION = 3,
    DXVAHD_FILTER_NOISE_REDUCTION = 4,
    DXVAHD_FILTER_EDGE_ENHANCEMENT = 5,
    DXVAHD_FILTER_ANAMORPHIC_SCALING = 6,
}
