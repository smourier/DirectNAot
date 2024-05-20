#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_input_format_caps
public enum DXVAHD_INPUT_FORMAT_CAPS
{
    DXVAHD_INPUT_FORMAT_CAPS_RGB_INTERLACED = 1,
    DXVAHD_INPUT_FORMAT_CAPS_RGB_PROCAMP = 2,
    DXVAHD_INPUT_FORMAT_CAPS_RGB_LUMA_KEY = 4,
    DXVAHD_INPUT_FORMAT_CAPS_PALETTE_INTERLACED = 8,
}
