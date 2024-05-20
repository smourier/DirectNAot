#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MIPI_DSI_PACKET
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public byte _bitfield;
        }
        
        [FieldOffset(0)]
        public byte DataId;
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public byte Data0;
            public byte Data1;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public ushort LongWriteWordCount;
    }
    
    public _Anonymous1_e__Union Anonymous1;
    public _Anonymous2_e__Union Anonymous2;
    public byte EccFiller;
    public InlineArrayByte_8 Payload;
}
