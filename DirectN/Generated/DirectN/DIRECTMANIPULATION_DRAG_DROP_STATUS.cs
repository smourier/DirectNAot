#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_drag_drop_status
public enum DIRECTMANIPULATION_DRAG_DROP_STATUS
{
    DIRECTMANIPULATION_DRAG_DROP_READY = 0,
    DIRECTMANIPULATION_DRAG_DROP_PRESELECT = 1,
    DIRECTMANIPULATION_DRAG_DROP_SELECTING = 2,
    DIRECTMANIPULATION_DRAG_DROP_DRAGGING = 3,
    DIRECTMANIPULATION_DRAG_DROP_CANCELLED = 4,
    DIRECTMANIPULATION_DRAG_DROP_COMMITTED = 5,
}
