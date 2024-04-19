namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-mfclock_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct MFCLOCK_PROPERTIES
{
    public ulong qwCorrelationRate;
    public Guid guidClockId;
    public uint dwClockFlags;
    public ulong qwClockFrequency;
    public uint dwClockTolerance;
    public uint dwClockJitter;
}
