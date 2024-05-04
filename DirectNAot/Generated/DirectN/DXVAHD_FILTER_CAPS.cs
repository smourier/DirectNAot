#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_filter_caps
public enum DXVAHD_FILTER_CAPS
{
    DXVAHD_FILTER_CAPS_BRIGHTNESS = 1,
    DXVAHD_FILTER_CAPS_CONTRAST = 2,
    DXVAHD_FILTER_CAPS_HUE = 4,
    DXVAHD_FILTER_CAPS_SATURATION = 8,
    DXVAHD_FILTER_CAPS_NOISE_REDUCTION = 16,
    DXVAHD_FILTER_CAPS_EDGE_ENHANCEMENT = 32,
    DXVAHD_FILTER_CAPS_ANAMORPHIC_SCALING = 64,
}
