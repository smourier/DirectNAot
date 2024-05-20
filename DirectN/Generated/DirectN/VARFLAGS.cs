﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ne-oaidl-varflags
public enum VARFLAGS : ushort
{
    VARFLAG_FREADONLY = 1,
    VARFLAG_FSOURCE = 2,
    VARFLAG_FBINDABLE = 4,
    VARFLAG_FREQUESTEDIT = 8,
    VARFLAG_FDISPLAYBIND = 16,
    VARFLAG_FDEFAULTBIND = 32,
    VARFLAG_FHIDDEN = 64,
    VARFLAG_FRESTRICTED = 128,
    VARFLAG_FDEFAULTCOLLELEM = 256,
    VARFLAG_FUIDEFAULT = 512,
    VARFLAG_FNONBROWSABLE = 1024,
    VARFLAG_FREPLACEABLE = 2048,
    VARFLAG_FIMMEDIATEBIND = 4096,
}
