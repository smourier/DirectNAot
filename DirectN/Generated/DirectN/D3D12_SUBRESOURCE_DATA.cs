﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_subresource_data
public partial struct D3D12_SUBRESOURCE_DATA
{
    public nint pData;
    public nint RowPitch;
    public nint SlicePitch;
}
