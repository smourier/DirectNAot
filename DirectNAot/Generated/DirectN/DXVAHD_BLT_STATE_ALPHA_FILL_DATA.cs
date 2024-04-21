﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_blt_state_alpha_fill_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_BLT_STATE_ALPHA_FILL_DATA
{
    public DXVAHD_ALPHA_FILL_MODE Mode;
    public uint StreamNumber;
}