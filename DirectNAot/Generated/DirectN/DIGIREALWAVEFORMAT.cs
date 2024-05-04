#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DIGIREALWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
