#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct VOLUMEWAVEFILTER
{
    public WAVEFILTER wfltr;
    public uint dwVolume;
}
