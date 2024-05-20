#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-dialog_dpi_change_behaviors
[Flags]
public enum DIALOG_DPI_CHANGE_BEHAVIORS
{
    DDC_DEFAULT = 0,
    DDC_DISABLE_ALL = 1,
    DDC_DISABLE_RESIZE = 2,
    DDC_DISABLE_CONTROL_RELAYOUT = 4,
}
