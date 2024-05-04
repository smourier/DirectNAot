﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MIDIOUTCAPS2A
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArrayFoundationCHAR32 szPname;
    public ushort wTechnology;
    public ushort wVoices;
    public ushort wNotes;
    public ushort wChannelMask;
    public uint dwSupport;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;
}
