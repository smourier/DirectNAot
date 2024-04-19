namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VOLUMEWAVEFILTER
{
    public WAVEFILTER wfltr;
    public uint dwVolume;
}
