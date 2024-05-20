﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_query_heap_type
public enum D3D12_QUERY_HEAP_TYPE
{
    D3D12_QUERY_HEAP_TYPE_OCCLUSION = 0,
    D3D12_QUERY_HEAP_TYPE_TIMESTAMP = 1,
    D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS = 2,
    D3D12_QUERY_HEAP_TYPE_SO_STATISTICS = 3,
    D3D12_QUERY_HEAP_TYPE_VIDEO_DECODE_STATISTICS = 4,
    D3D12_QUERY_HEAP_TYPE_COPY_QUEUE_TIMESTAMP = 5,
    D3D12_QUERY_HEAP_TYPE_PIPELINE_STATISTICS1 = 7,
}