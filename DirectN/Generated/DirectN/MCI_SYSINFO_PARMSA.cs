﻿#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_SYSINFO_PARMSA
{
    public nuint dwCallback;
    public PSTR lpstrReturn;
    public uint dwRetSize;
    public uint dwNumber;
    public uint wDeviceType;
}
