#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSNODEPROPERTY_AUDIO_CHANNEL
{
    public KSNODEPROPERTY NodeProperty;
    public int Channel;
    public uint Reserved;
}
