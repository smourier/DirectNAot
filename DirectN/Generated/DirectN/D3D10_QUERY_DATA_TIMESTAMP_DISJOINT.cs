﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_query_data_timestamp_disjoint
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_QUERY_DATA_TIMESTAMP_DISJOINT
{
    public ulong Frequency;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Disjoint;
}