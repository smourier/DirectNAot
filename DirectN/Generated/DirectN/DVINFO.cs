﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvinfo
public partial struct DVINFO
{
    public uint dwDVAAuxSrc;
    public uint dwDVAAuxCtl;
    public uint dwDVAAuxSrc1;
    public uint dwDVAAuxCtl1;
    public uint dwDVVAuxSrc;
    public uint dwDVVAuxCtl;
    public InlineArrayUInt32_2 dwDVReserved;
}
