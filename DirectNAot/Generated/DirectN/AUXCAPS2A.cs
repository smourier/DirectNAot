﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct AUXCAPS2A
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArrayFoundationCHAR32 szPname;
    public ushort wTechnology;
    public ushort wReserved1;
    public uint dwSupport;
    public Guid ManufacturerGuid;
    public Guid ProductGuid;
    public Guid NameGuid;
}
