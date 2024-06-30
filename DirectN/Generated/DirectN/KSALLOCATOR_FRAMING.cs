#nullable enable
namespace DirectN;

public partial struct KSALLOCATOR_FRAMING
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public uint OptionsFlags;
        
        [FieldOffset(0)]
        public uint RequirementsFlags;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public uint FileAlignment;
        
        [FieldOffset(0)]
        public int FramePitch;
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public uint PoolType;
    public uint Frames;
    public uint FrameSize;
    public _Anonymous2_e__Union Anonymous2;
    public uint Reserved;
}
