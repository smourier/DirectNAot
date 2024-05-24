#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct CREATIVEFASTSPEECH8WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
}
