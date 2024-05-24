#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ADPCMWAVEFORMAT
{
    public WAVEFORMATEX wfx;
    public ushort wSamplesPerBlock;
    public ushort wNumCoef;
    public InlineArrayADPCMCOEFSET_1 aCoef;
}
