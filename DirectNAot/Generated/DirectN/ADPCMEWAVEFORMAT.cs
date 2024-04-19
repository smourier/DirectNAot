namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ADPCMEWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
