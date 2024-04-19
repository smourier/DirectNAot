namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSEVENT_TUNER_INITIATE_SCAN_S
{
    public KSEVENTDATA EventData;
    public uint StartFrequency;
    public uint EndFrequency;
}
