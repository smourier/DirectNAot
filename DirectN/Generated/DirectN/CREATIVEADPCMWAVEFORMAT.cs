#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CREATIVEADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
}
