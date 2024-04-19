namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-regfilter2
[StructLayout(LayoutKind.Sequential)]
public partial struct REGFILTER2
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous1_e__Struct
        {
            public uint cPins;
            public nint rgPins;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Anonymous2_e__Struct
        {
            public uint cPins2;
            public nint rgPins2;
        }
        
        [FieldOffset(0)]
        public _Anonymous1_e__Struct Anonymous1;
        
        [FieldOffset(0)]
        public _Anonymous2_e__Struct Anonymous2;
    }
    
    public uint dwVersion;
    public uint dwMerit;
    public _Anonymous_e__Union Anonymous;
}
