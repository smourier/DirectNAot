#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ECHOWAVEFILTER
{
    public WAVEFILTER wfltr;
    public uint dwVolume;
    public uint dwDelay;
}
