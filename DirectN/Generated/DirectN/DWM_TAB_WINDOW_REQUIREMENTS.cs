#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwmapi/ne-dwmapi-dwm_tab_window_requirements
[Flags]
public enum DWM_TAB_WINDOW_REQUIREMENTS
{
    DWMTWR_NONE = 0,
    DWMTWR_IMPLEMENTED_BY_SYSTEM = 1,
    DWMTWR_WINDOW_RELATIONSHIP = 2,
    DWMTWR_WINDOW_STYLES = 4,
    DWMTWR_WINDOW_REGION = 8,
    DWMTWR_WINDOW_DWM_ATTRIBUTES = 16,
    DWMTWR_WINDOW_MARGINS = 32,
    DWMTWR_TABBING_ENABLED = 64,
    DWMTWR_USER_POLICY = 128,
    DWMTWR_GROUP_POLICY = 256,
    DWMTWR_APP_COMPAT = 512,
}
