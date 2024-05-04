#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MEDIASPACEADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
}
