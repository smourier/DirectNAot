#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WMAUDIO3WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wValidBitsPerSample;
    public uint dwChannelMask;
    public uint dwReserved1;
    public uint dwReserved2;
    public ushort wEncodeOptions;
    public ushort wReserved3;
}
