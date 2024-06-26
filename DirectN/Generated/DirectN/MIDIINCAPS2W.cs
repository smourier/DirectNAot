﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIINCAPS2W
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar_32 szPname;
    public uint dwSupport;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;
}
