#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DIGIADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
