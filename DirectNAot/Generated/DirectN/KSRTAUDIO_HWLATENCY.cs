#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSRTAUDIO_HWLATENCY
{
    public uint FifoSize;
    public uint ChipsetDelay;
    public uint CodecDelay;
}
