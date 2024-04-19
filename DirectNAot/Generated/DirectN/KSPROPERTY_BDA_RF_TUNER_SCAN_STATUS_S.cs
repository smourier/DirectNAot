namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_BDA_RF_TUNER_SCAN_STATUS_S
{
    public KSP_NODE Property;
    public uint CurrentFrequency;
    public uint FrequencyRangeMin;
    public uint FrequencyRangeMax;
    public uint MilliSecondsLeft;
}
