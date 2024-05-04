#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AMBISONICS_PARAMS
{
    public uint u32Size;
    public uint u32Version;
    public AMBISONICS_TYPE u32Type;
    public AMBISONICS_CHANNEL_ORDERING u32ChannelOrdering;
    public AMBISONICS_NORMALIZATION u32Normalization;
    public uint u32Order;
    public uint u32NumChannels;
    public nint pu32ChannelMap;
}
