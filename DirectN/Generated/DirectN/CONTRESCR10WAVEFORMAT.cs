#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CONTRESCR10WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
