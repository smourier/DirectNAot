#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct G723_ADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort cbExtraSize;
    public ushort nAuxBlockSize;
}
