﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_kernelcallbacks
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_KERNELCALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint SyncSurfaceData;
    public nint SyncVideoPortData;
}
