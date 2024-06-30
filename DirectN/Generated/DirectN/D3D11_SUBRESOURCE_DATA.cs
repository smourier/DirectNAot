﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_subresource_data
public partial struct D3D11_SUBRESOURCE_DATA
{
    public nint pSysMem;
    public uint SysMemPitch;
    public uint SysMemSlicePitch;
}
