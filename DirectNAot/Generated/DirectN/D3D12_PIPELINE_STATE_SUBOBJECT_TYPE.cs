﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_pipeline_state_subobject_type
public enum D3D12_PIPELINE_STATE_SUBOBJECT_TYPE
{
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE = 0,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS = 1,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS = 2,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS = 3,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS = 4,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS = 5,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS = 6,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT = 7,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND = 8,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK = 9,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER = 10,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL = 11,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT = 12,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE = 13,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY = 14,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS = 15,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT = 16,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC = 17,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK = 18,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO = 19,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS = 20,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1 = 21,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING = 22,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS = 24,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS = 25,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL2 = 26,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER1 = 27,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER2 = 28,
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID = 29,
}
