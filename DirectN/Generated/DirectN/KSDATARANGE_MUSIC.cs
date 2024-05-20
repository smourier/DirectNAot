#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSDATARANGE_MUSIC
{
    public KSDATAFORMAT DataRange;
    public Guid Technology;
    public uint Channels;
    public uint Notes;
    public uint ChannelMask;
}
