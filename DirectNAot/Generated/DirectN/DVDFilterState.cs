#nullable enable
namespace DirectN;

public enum DVDFilterState
{
    dvdState_Undefined = -2,
    dvdState_Unitialized = -1,
    dvdState_Stopped = 0,
    dvdState_Paused = 1,
    dvdState_Running = 2,
}
