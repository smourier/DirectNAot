#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WMAUDIO2WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public uint dwSamplesPerBlock;
    public ushort wEncodeOptions;
    public uint dwSuperBlockAlign;
}
