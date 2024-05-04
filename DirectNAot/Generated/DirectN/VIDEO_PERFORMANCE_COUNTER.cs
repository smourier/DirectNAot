#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_PERFORMANCE_COUNTER
{
    public InlineArrayUInt6410 NbOfAllocationEvicted;
    public InlineArrayUInt6410 NbOfAllocationMarked;
    public InlineArrayUInt6410 NbOfAllocationRestored;
    public InlineArrayUInt6410 KBytesEvicted;
    public InlineArrayUInt6410 KBytesMarked;
    public InlineArrayUInt6410 KBytesRestored;
    public ulong NbProcessCommited;
    public ulong NbAllocationCommited;
    public ulong NbAllocationMarked;
    public ulong KBytesAllocated;
    public ulong KBytesAvailable;
    public ulong KBytesCurMarked;
    public ulong Reference;
    public ulong Unreference;
    public ulong TrueReference;
    public ulong NbOfPageIn;
    public ulong KBytesPageIn;
    public ulong NbOfPageOut;
    public ulong KBytesPageOut;
    public ulong NbOfRotateOut;
    public ulong KBytesRotateOut;
}
