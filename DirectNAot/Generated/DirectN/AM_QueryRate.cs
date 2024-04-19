﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_queryrate
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_QueryRate
{
    public int lMaxForwardFullFrame;
    public int lMaxReverseFullFrame;
}
