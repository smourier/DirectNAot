﻿#nullable enable
namespace DirectN;

public partial struct DD_HALINFO_V4
{
    public uint dwSize;
    public VIDEOMEMORYINFO vmiData;
    public DDNTCORECAPS ddCaps;
    public nint GetDriverInfo;
    public uint dwFlags;
}
