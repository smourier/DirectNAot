﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxva_coppstatusdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_COPPStatusData
{
    public Guid rApp;
    public uint dwFlags;
    public uint dwData;
    public uint ExtendedInfoValidMask;
    public uint ExtendedInfoData;
}
