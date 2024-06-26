﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmreg/ns-mmreg-wavefilter
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEFILTER
{
    public uint cbStruct;
    public uint dwFilterTag;
    public uint fdwFilter;
    public InlineArrayUInt32_5 dwReserved;
}
