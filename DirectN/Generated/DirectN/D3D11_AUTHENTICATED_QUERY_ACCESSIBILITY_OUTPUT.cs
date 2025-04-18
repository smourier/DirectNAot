﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_authenticated_query_accessibility_output
public partial struct D3D11_AUTHENTICATED_QUERY_ACCESSIBILITY_OUTPUT
{
    public D3D11_AUTHENTICATED_QUERY_OUTPUT Output;
    public D3D11_BUS_TYPE BusType;
    public BOOL AccessibleInContiguousBlocks;
    public BOOL AccessibleInNonContiguousBlocks;
}
