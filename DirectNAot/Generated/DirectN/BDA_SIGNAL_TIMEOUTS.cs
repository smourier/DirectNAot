namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_SIGNAL_TIMEOUTS
{
    public uint ulCarrierTimeoutMs;
    public uint ulScanningTimeoutMs;
    public uint ulTuningTimeoutMs;
}
