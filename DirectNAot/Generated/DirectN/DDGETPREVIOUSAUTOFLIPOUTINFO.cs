﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-ddgetpreviousautoflipoutinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGETPREVIOUSAUTOFLIPOUTINFO
{
    public uint dwSurfaceIndex;
    public uint dwVBISurfaceIndex;
}
