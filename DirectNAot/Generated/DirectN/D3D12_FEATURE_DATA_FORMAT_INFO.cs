﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_format_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_FORMAT_INFO
{
    public DXGI_FORMAT Format;
    public byte PlaneCount;
}