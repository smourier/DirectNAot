﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2Trace_DecodeDevCreatedData
{
    public EVENT_TRACE_HEADER wmiHeader;
    public ulong pObject;
    public ulong pD3DDevice;
    public Guid DeviceGuid;
    public uint Width;
    public uint Height;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Enter;
}