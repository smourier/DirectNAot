#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_feature_caps
public enum DXVAHD_FEATURE_CAPS
{
    DXVAHD_FEATURE_CAPS_ALPHA_FILL = 1,
    DXVAHD_FEATURE_CAPS_CONSTRICTION = 2,
    DXVAHD_FEATURE_CAPS_LUMA_KEY = 4,
    DXVAHD_FEATURE_CAPS_ALPHA_PALETTE = 8,
}
