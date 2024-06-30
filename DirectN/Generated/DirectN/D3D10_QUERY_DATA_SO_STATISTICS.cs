﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/ns-d3d10-d3d10_query_data_so_statistics
public partial struct D3D10_QUERY_DATA_SO_STATISTICS
{
    public ulong NumPrimitivesWritten;
    public ulong PrimitivesStorageNeeded;
}
