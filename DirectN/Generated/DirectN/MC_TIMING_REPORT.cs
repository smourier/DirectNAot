#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/lowlevelmonitorconfigurationapi/ns-lowlevelmonitorconfigurationapi-mc_timing_report
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MC_TIMING_REPORT
{
    public uint dwHorizontalFrequencyInHZ;
    public uint dwVerticalFrequencyInHZ;
    public byte bTimingStatusByte;
}
