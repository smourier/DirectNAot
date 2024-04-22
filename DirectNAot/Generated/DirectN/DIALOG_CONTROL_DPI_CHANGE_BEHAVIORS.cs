namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-dialog_control_dpi_change_behaviors
[Flags]
public enum DIALOG_CONTROL_DPI_CHANGE_BEHAVIORS
{
    DCDC_DEFAULT = 0,
    DCDC_DISABLE_FONT_UPDATE = 1,
    DCDC_DISABLE_RELAYOUT = 2,
}
