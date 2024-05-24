#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ECHOWAVEFILTER
{
    public WAVEFILTER wfltr;
    public uint dwVolume;
    public uint dwDelay;
}
