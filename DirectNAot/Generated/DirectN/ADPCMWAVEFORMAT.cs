namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
    public ushort wNumCoef;
    public InlineArrayADPCMCOEFSET1 aCoef;
}
