﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_state_alpha_data
public partial struct DXVAHD_STREAM_STATE_ALPHA_DATA
{
    public BOOL Enable;
    public float Alpha;
}
