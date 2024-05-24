#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct G721_ADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort nAuxBlockSize;
}
