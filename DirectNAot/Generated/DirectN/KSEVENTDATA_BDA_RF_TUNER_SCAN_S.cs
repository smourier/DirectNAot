namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSEVENTDATA_BDA_RF_TUNER_SCAN_S
{
    public KSEVENTDATA EventData;
    public uint StartFrequency;
    public uint EndFrequency;
    public BDA_LockType LockRequested;
}
