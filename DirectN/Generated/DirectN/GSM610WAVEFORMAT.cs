#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GSM610WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
}
