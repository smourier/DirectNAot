#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct TRUESPEECHWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wRevision;
    public ushort nSamplesPerBlock;
    public InlineArrayByte_28 abReserved;
}
