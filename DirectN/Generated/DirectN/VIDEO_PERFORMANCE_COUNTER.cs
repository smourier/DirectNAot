#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEO_PERFORMANCE_COUNTER
{
    public InlineArrayUInt64_10 NbOfAllocationEvicted;
    public InlineArrayUInt64_10 NbOfAllocationMarked;
    public InlineArrayUInt64_10 NbOfAllocationRestored;
    public InlineArrayUInt64_10 KBytesEvicted;
    public InlineArrayUInt64_10 KBytesMarked;
    public InlineArrayUInt64_10 KBytesRestored;
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
