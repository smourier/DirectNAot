﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddrawint/ns-ddrawint-dd_endmocompframedata
[StructLayout(LayoutKind.Sequential)]
public partial struct DD_ENDMOCOMPFRAMEDATA
{
    public nint lpDD;
    public nint lpMoComp;
    public nint lpInputData;
    public uint dwInputDataSize;
    public HRESULT ddRVal;
}
