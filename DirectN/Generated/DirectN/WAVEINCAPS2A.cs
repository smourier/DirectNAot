﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEINCAPS2A
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArrayFoundationCHAR_32 szPname;
    public uint dwFormats;
    public ushort wChannels;
    public ushort wReserved1;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;
}
