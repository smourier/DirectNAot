#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_BDA_FRAME_INFO
{
    public uint ExtendedHeaderSize;
    public uint dwFrameFlags;
    public uint ulEvent;
    public uint ulChannelNumber;
    public uint ulSubchannelNumber;
    public uint ulReason;
}
