#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_alpha_fill_mode
public enum DXVAHD_ALPHA_FILL_MODE
{
    DXVAHD_ALPHA_FILL_MODE_OPAQUE = 0,
    DXVAHD_ALPHA_FILL_MODE_BACKGROUND = 1,
    DXVAHD_ALPHA_FILL_MODE_DESTINATION = 2,
    DXVAHD_ALPHA_FILL_MODE_SOURCE_STREAM = 3,
}
