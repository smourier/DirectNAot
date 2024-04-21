﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_DISEQC_SEND
{
    public uint ulRequestId;
    public uint ulPacketLength;
    public InlineArrayByte8 argbPacketData;
}