#nullable enable
namespace DirectN;

public partial struct ALLOCATOR_PROPERTIES_EX
{
    public int cBuffers;
    public int cbBuffer;
    public int cbAlign;
    public int cbPrefix;
    public Guid MemoryType;
    public Guid BusType;
    public PIPE_STATE State;
    public PIPE_TERMINATION Input;
    public PIPE_TERMINATION Output;
    public uint Strategy;
    public uint Flags;
    public uint Weight;
    public KS_LogicalMemoryType LogicalMemoryType;
    public PIPE_ALLOCATOR_PLACE AllocatorPlace;
    public PIPE_DIMENSIONS Dimensions;
    public KS_FRAMING_RANGE PhysicalRange;
    public nint PrevSegment;
    public uint CountNextSegments;
    public nint NextSegments;
    public uint InsideFactors;
    public uint NumberPins;
}
