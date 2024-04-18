﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_discard_region
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DISCARD_REGION
{
    public uint NumRects;
    public FoundationRECT pRects;
    public uint FirstSubresource;
    public uint NumSubresources;
}
