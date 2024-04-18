﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_DATA_1
{
    public InlineArraySystemChar64 sztPortName;
    public uint dwVersion;
    public uint dwProtocol;
    public uint cbSize;
    public uint dwReserved;
    public InlineArrayChar49 sztHostAddress;
    public InlineArrayChar33 sztSNMPCommunity;
    public uint dwDoubleSpool;
    public InlineArrayChar33 sztQueue;
    public InlineArrayChar16 sztIPAddress;
    public InlineArrayByte540 Reserved;
    public uint dwPortNumber;
    public uint dwSNMPEnabled;
    public uint dwSNMPDevIndex;
}
