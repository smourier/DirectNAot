namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct IMAADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
