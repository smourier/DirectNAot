namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct TRUESPEECHWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
    public ushort nSamplesPerBlock;
    public InlineArrayByte28 abReserved;
}
