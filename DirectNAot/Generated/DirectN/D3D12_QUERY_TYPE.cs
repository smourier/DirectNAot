﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_query_type
public enum D3D12_QUERY_TYPE
{
    D3D12_QUERY_TYPE_OCCLUSION = 0,
    D3D12_QUERY_TYPE_BINARY_OCCLUSION = 1,
    D3D12_QUERY_TYPE_TIMESTAMP = 2,
    D3D12_QUERY_TYPE_PIPELINE_STATISTICS = 3,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM0 = 4,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM1 = 5,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM2 = 6,
    D3D12_QUERY_TYPE_SO_STATISTICS_STREAM3 = 7,
    D3D12_QUERY_TYPE_VIDEO_DECODE_STATISTICS = 8,
    D3D12_QUERY_TYPE_PIPELINE_STATISTICS1 = 10,
}