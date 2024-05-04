﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_state_subobject_type
public enum D3D12_STATE_SUBOBJECT_TYPE
{
    D3D12_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG = 0,
    D3D12_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE = 1,
    D3D12_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE = 2,
    D3D12_STATE_SUBOBJECT_TYPE_NODE_MASK = 3,
    D3D12_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY = 5,
    D3D12_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION = 6,
    D3D12_STATE_SUBOBJECT_TYPE_SUBOBJECT_TO_EXPORTS_ASSOCIATION = 7,
    D3D12_STATE_SUBOBJECT_TYPE_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION = 8,
    D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG = 9,
    D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG = 10,
    D3D12_STATE_SUBOBJECT_TYPE_HIT_GROUP = 11,
    D3D12_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG1 = 12,
    D3D12_STATE_SUBOBJECT_TYPE_MAX_VALID = 13,
}
