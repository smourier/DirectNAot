#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct FMTOWNS_SND_WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
}
