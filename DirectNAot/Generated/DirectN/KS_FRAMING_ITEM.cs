namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_FRAMING_ITEM
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public uint FileAlignment;
        
        [FieldOffset(0)]
        public int FramePitch;
    }
    
    public Guid MemoryType;
    public Guid BusType;
    public uint MemoryFlags;
    public uint BusFlags;
    public uint Flags;
    public uint Frames;
    public _Anonymous_e__Union Anonymous;
    public uint MemoryTypeWeight;
    public KS_FRAMING_RANGE PhysicalRange;
    public KS_FRAMING_RANGE_WEIGHTED FramingRange;
}
