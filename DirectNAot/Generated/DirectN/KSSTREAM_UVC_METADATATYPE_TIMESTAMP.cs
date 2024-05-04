#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSSTREAM_UVC_METADATATYPE_TIMESTAMP
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public ushort _bitfield;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public ushort SCRToken;
    }
    
    public uint PresentationTimeStamp;
    public uint SourceClockReference;
    public _Anonymous_e__Union Anonymous;
    public ushort Reserved0;
    public uint Reserved1;
}
