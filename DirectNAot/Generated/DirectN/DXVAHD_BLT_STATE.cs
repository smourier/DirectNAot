#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_blt_state
public enum DXVAHD_BLT_STATE
{
    DXVAHD_BLT_STATE_TARGET_RECT = 0,
    DXVAHD_BLT_STATE_BACKGROUND_COLOR = 1,
    DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE = 2,
    DXVAHD_BLT_STATE_ALPHA_FILL = 3,
    DXVAHD_BLT_STATE_CONSTRICTION = 4,
    DXVAHD_BLT_STATE_PRIVATE = 1000,
}
