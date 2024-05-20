#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SIERRAADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
}
