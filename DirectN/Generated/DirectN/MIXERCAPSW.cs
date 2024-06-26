﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercapsw
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCAPSW
{
    public ushort wMid;
    public ushort wPid;
    public uint vDriverVersion;
    public InlineArraySystemChar_32 szPname;
    public uint fdwSupport;
    public uint cDestinations;
}
