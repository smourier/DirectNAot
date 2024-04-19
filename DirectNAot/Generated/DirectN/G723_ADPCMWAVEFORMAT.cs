namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct G723_ADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort cbExtraSize;
    public ushort nAuxBlockSize;
}
