﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MMTIME
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _u_e__Union
    {
        public struct _smpte_e__Struct
        {
            public byte hour;
            public byte min;
            public byte sec;
            public byte frame;
            public byte fps;
            public byte dummy;
            public InlineArrayByte_2 pad;
        }
        
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct _midi_e__Struct
        {
            public uint songptrpos;
        }
        
        [FieldOffset(0)]
        public uint ms;
        
        [FieldOffset(0)]
        public uint sample;
        
        [FieldOffset(0)]
        public uint cb;
        
        [FieldOffset(0)]
        public uint ticks;
        
        [FieldOffset(0)]
        public _smpte_e__Struct smpte;
        
        [FieldOffset(0)]
        public _midi_e__Struct midi;
    }
    
    public uint wType;
    public _u_e__Union u;
}
