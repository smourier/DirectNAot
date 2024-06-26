﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ne-d3d11shadertracing-d3d11_trace_register_type
public enum D3D11_TRACE_REGISTER_TYPE
{
    D3D11_TRACE_OUTPUT_NULL_REGISTER = 0,
    D3D11_TRACE_INPUT_REGISTER = 1,
    D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER = 2,
    D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER = 3,
    D3D11_TRACE_TEMP_REGISTER = 4,
    D3D11_TRACE_INDEXABLE_TEMP_REGISTER = 5,
    D3D11_TRACE_OUTPUT_REGISTER = 6,
    D3D11_TRACE_OUTPUT_DEPTH_REGISTER = 7,
    D3D11_TRACE_CONSTANT_BUFFER = 8,
    D3D11_TRACE_IMMEDIATE32 = 9,
    D3D11_TRACE_SAMPLER = 10,
    D3D11_TRACE_RESOURCE = 11,
    D3D11_TRACE_RASTERIZER = 12,
    D3D11_TRACE_OUTPUT_COVERAGE_MASK = 13,
    D3D11_TRACE_STREAM = 14,
    D3D11_TRACE_THIS_POINTER = 15,
    D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER = 16,
    D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER = 17,
    D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER = 18,
    D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER = 19,
    D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER = 20,
    D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER = 21,
    D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER = 22,
    D3D11_TRACE_UNORDERED_ACCESS_VIEW = 23,
    D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY = 24,
    D3D11_TRACE_INPUT_THREAD_ID_REGISTER = 25,
    D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER = 26,
    D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER = 27,
    D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER = 28,
    D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER = 29,
    D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER = 30,
    D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER = 31,
    D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER = 32,
    D3D11_TRACE_IMMEDIATE64 = 33,
    D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER = 34,
    D3D11_TRACE_INTERFACE_POINTER = 35,
}
