#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CONTRESVQLPCWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
