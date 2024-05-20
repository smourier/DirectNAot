﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SECURE_BUFFER_INFO
{
    public Guid guidBufferIdentifier;
    public uint cbBufferSize;
    public uint cbCaptured;
    public InlineArrayUInt64_16 ullReserved;
}
