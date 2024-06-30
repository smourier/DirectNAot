#nullable enable
namespace DirectN;

public partial struct KS_BDA_FRAME_INFO
{
    public uint ExtendedHeaderSize;
    public uint dwFrameFlags;
    public uint ulEvent;
    public uint ulChannelNumber;
    public uint ulSubchannelNumber;
    public uint ulReason;
}
