﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct AVITCDLINDEX_ENTRY
{
    public uint dwTick;
    public TIMECODE time;
    public uint dwSMPTEflags;
    public uint dwUser;
    public InlineArraySByte_12 szReelId;
}
