﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2structs/ns-mpeg2structs-mpeg_date
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEG_DATE
{
    public byte Date;
    public byte Month;
    public ushort Year;
}
