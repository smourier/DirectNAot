#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_blt_state_background_color_data
public partial struct DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA
{
    public BOOL YCbCr;
    public DXVAHD_COLOR BackgroundColor;
}
