namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct KSDATAFORMAT
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _Anonymous_e__Struct
    {
        public uint FormatSize;
        public uint Flags;
        public uint SampleSize;
        public uint Reserved;
        public Guid MajorFormat;
        public Guid SubFormat;
        public Guid Specifier;
    }
    
    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;
    
    [FieldOffset(0)]
    public long Alignment;
}
