﻿#nullable enable
namespace DirectN;

public partial struct DDMCCOMPBUFFERINFO
{
    public uint dwSize;
    public uint dwNumCompBuffers;
    public uint dwWidthToCreate;
    public uint dwHeightToCreate;
    public uint dwBytesToAllocate;
    public DDSCAPS2 ddCompCaps;
    public DDPIXELFORMAT ddPixelFormat;
}
