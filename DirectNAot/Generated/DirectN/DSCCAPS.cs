﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwFormats;
    public uint dwChannels;
}
