#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/ns-sbe-sbe_pin_data
public partial struct SBE_PIN_DATA
{
    public ulong cDataBytes;
    public ulong cSamplesProcessed;
    public ulong cDiscontinuities;
    public ulong cSyncPoints;
    public ulong cTimestamps;
}
