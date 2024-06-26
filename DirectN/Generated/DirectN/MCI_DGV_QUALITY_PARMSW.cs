﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/digitalv/ns-digitalv-mci_dgv_quality_parmsw
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_DGV_QUALITY_PARMSW
{
    public nuint dwCallback;
    public uint dwItem;
    public PWSTR lpstrName;
    public uint lpstrAlgorithm;
    public uint dwHandle;
}
