﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_threading
public partial struct D3D11_FEATURE_DATA_THREADING
{
    public BOOL DriverConcurrentCreates;
    public BOOL DriverCommandLists;
}
