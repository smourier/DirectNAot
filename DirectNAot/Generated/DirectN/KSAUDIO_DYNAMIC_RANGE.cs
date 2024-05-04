#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAUDIO_DYNAMIC_RANGE
{
    public uint QuietCompression;
    public uint LoudCompression;
}
