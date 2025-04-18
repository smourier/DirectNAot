#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_blt_state_target_rect_data
public partial struct DXVAHD_BLT_STATE_TARGET_RECT_DATA
{
    public BOOL Enable;
    public RECT TargetRect;
}
