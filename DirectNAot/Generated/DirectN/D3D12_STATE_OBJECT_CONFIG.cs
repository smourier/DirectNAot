﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_state_object_config
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_STATE_OBJECT_CONFIG
{
    public D3D12_STATE_OBJECT_FLAGS Flags;
}
