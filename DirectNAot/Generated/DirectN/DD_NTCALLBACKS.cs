﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_ntcallbacks
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_NTCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint FreeDriverMemory;
    public nint SetExclusiveMode;
    public nint FlipToGDISurface;
}
