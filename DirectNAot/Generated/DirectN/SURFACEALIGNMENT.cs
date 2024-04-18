namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmemmgr/ns-dmemmgr-surfacealignment
[StructLayout(LayoutKind.Sequential)]
public partial struct SURFACEALIGNMENT
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Linear_e__Struct
        {
            public uint dwStartAlignment;
            public uint dwPitchAlignment;
            public uint dwFlags;
            public uint dwReserved2;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _Rectangular_e__Struct
        {
            public uint dwXAlignment;
            public uint dwYAlignment;
            public uint dwFlags;
            public uint dwReserved2;
        }
        
        [FieldOffset(0)]
        public _Linear_e__Struct Linear;
        
        [FieldOffset(0)]
        public _Rectangular_e__Struct Rectangular;
    }
    
    public _Anonymous_e__Union Anonymous;
}
