#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfclock_state
public enum MFCLOCK_STATE
{
    MFCLOCK_STATE_INVALID = 0,
    MFCLOCK_STATE_RUNNING = 1,
    MFCLOCK_STATE_STOPPED = 2,
    MFCLOCK_STATE_PAUSED = 3,
}
