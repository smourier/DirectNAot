namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wtypes/ns-wtypes-decimal~r1
[StructLayout(LayoutKind.Sequential)]
public partial struct DECIMAL
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous1_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public byte scale;
            public byte sign;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public ushort signscale;
    }
    
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous2_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous_e__Struct
        {
            public uint Lo32;
            public uint Mid32;
        }
        
        [FieldOffset(0)]
        public _Anonymous_e__Struct Anonymous;
        
        [FieldOffset(0)]
        public ulong Lo64;
    }
    
    public ushort wReserved;
    public _Anonymous1_e__Union Anonymous1;
    public uint Hi32;
    public _Anonymous2_e__Union Anonymous2;
}
