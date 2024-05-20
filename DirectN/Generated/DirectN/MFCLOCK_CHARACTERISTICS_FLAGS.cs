#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfclock_characteristics_flags
public enum MFCLOCK_CHARACTERISTICS_FLAGS
{
    MFCLOCK_CHARACTERISTICS_FLAG_FREQUENCY_10MHZ = 2,
    MFCLOCK_CHARACTERISTICS_FLAG_ALWAYS_RUNNING = 4,
    MFCLOCK_CHARACTERISTICS_FLAG_IS_SYSTEM_CLOCK = 8,
}
