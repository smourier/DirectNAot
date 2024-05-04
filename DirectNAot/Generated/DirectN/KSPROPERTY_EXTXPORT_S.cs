﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_EXTXPORT_S
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _u_e__Union
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct _Timecode_e__Struct
        {
            public byte frame;
            public byte second;
            public byte minute;
            public byte hour;
        }
        
        [StructLayout(LayoutKind.Sequential)]
        public struct _RawAVC_e__Struct
        {
            public uint PayloadSize;
            public InlineArrayByte512 Payload;
        }
        
        [FieldOffset(0)]
        public uint Capabilities;
        
        [FieldOffset(0)]
        public uint SignalMode;
        
        [FieldOffset(0)]
        public uint LoadMedium;
        
        [FieldOffset(0)]
        public MEDIUM_INFO MediumInfo;
        
        [FieldOffset(0)]
        public TRANSPORT_STATE XPrtState;
        
        [FieldOffset(0)]
        public _Timecode_e__Struct Timecode;
        
        [FieldOffset(0)]
        public uint dwTimecode;
        
        [FieldOffset(0)]
        public uint dwAbsTrackNumber;
        
        [FieldOffset(0)]
        public _RawAVC_e__Struct RawAVC;
    }
    
    public KSIDENTIFIER Property;
    public _u_e__Union u;
}
