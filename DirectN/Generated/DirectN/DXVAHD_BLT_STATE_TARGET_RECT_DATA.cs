﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_blt_state_target_rect_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_BLT_STATE_TARGET_RECT_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public RECT TargetRect;
}
