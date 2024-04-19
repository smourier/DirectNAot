namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WMAUDIO2WAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public uint dwSamplesPerBlock;
    public ushort wEncodeOptions;
    public uint dwSuperBlockAlign;
}
