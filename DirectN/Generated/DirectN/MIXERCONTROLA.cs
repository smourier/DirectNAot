#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontrola
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLA
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Bounds_e__Union
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct _Anonymous1_e__Struct
        {
            public int lMinimum;
            public int lMaximum;
        }
        
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct _Anonymous2_e__Struct
        {
            public uint dwMinimum;
            public uint dwMaximum;
        }
        
        [FieldOffset(0)]
        public _Anonymous1_e__Struct Anonymous1;
        
        [FieldOffset(0)]
        public _Anonymous2_e__Struct Anonymous2;
        
        [FieldOffset(0)]
        public InlineArrayUInt32_6 dwReserved;
    }
    
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Metrics_e__Union
    {
        [FieldOffset(0)]
        public uint cSteps;
        
        [FieldOffset(0)]
        public uint cbCustomData;
        
        [FieldOffset(0)]
        public InlineArrayUInt32_6 dwReserved;
    }
    
    public uint cbStruct;
    public uint dwControlID;
    public uint dwControlType;
    public uint fdwControl;
    public uint cMultipleItems;
    public InlineArrayFoundationCHAR_16 szShortName;
    public InlineArrayFoundationCHAR_64 szName;
    public _Bounds_e__Union Bounds;
    public _Metrics_e__Union Metrics;
}
