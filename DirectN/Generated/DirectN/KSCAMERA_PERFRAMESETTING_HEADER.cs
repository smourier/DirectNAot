#nullable enable
namespace DirectN;

public partial struct KSCAMERA_PERFRAMESETTING_HEADER
{
    public uint Size;
    public uint FrameCount;
    public Guid Id;
    public ulong Flags;
    public uint LoopCount;
    public uint Reserved;
}
