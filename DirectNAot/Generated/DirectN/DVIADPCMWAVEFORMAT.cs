namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DVIADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
