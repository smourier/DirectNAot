namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_TUNER_DIAGNOSTICS
{
    public int lResult;
    public uint ulSignalLevel;
    public uint ulSignalLevelQuality;
    public uint ulSignalNoiseRatio;
}
