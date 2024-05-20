#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CREATIVEADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
}
