#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct G721_ADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort nAuxBlockSize;
}
