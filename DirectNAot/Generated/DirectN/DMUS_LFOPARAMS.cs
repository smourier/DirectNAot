namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_LFOPARAMS
{
    public int pcFrequency;
    public int tcDelay;
    public int gcVolumeScale;
    public int pcPitchScale;
    public int gcMWToVolume;
    public int pcMWToPitch;
}
