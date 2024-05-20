#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MSAUDIO1WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
    public ushort wEncodeOptions;
}
