﻿#nullable enable
namespace DirectN;

public enum D3D12_NODE_OVERRIDES_TYPE
{
    D3D12_NODE_OVERRIDES_TYPE_NONE = 0,
    D3D12_NODE_OVERRIDES_TYPE_BROADCASTING_LAUNCH = 1,
    D3D12_NODE_OVERRIDES_TYPE_COALESCING_LAUNCH = 2,
    D3D12_NODE_OVERRIDES_TYPE_THREAD_LAUNCH = 3,
    D3D12_NODE_OVERRIDES_TYPE_COMMON_COMPUTE = 4,
}