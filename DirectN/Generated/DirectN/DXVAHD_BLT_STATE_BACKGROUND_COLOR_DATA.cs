#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_blt_state_background_color_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool YCbCr;
    public DXVAHD_COLOR BackgroundColor;
}
