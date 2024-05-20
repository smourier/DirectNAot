﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_set_parms
[StructLayout(LayoutKind.Sequential)]
public partial struct MCI_DGV_SET_PARMS
{
    public nuint dwCallback;
    public uint dwTimeFormat;
    public uint dwAudio;
    public uint dwFileFormat;
    public uint dwSpeed;
}
