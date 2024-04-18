﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_getvportflipstatusdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_GETVPORTFLIPSTATUSDATA
{
    public nint lpDD;
    public nuint fpSurface;
    
    [MarshalAs(UnmanagedType.Error)]
    public HRESULT ddRVal;
    public nint GetVideoPortFlipStatus;
}
