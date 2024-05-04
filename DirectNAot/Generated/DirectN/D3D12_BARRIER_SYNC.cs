﻿#nullable enable
namespace DirectN;

[Flags]
public enum D3D12_BARRIER_SYNC
{
    D3D12_BARRIER_SYNC_NONE = 0,
    D3D12_BARRIER_SYNC_ALL = 1,
    D3D12_BARRIER_SYNC_DRAW = 2,
    D3D12_BARRIER_SYNC_INDEX_INPUT = 4,
    D3D12_BARRIER_SYNC_VERTEX_SHADING = 8,
    D3D12_BARRIER_SYNC_PIXEL_SHADING = 16,
    D3D12_BARRIER_SYNC_DEPTH_STENCIL = 32,
    D3D12_BARRIER_SYNC_RENDER_TARGET = 64,
    D3D12_BARRIER_SYNC_COMPUTE_SHADING = 128,
    D3D12_BARRIER_SYNC_RAYTRACING = 256,
    D3D12_BARRIER_SYNC_COPY = 512,
    D3D12_BARRIER_SYNC_RESOLVE = 1024,
    D3D12_BARRIER_SYNC_EXECUTE_INDIRECT = 2048,
    D3D12_BARRIER_SYNC_PREDICATION = 2048,
    D3D12_BARRIER_SYNC_ALL_SHADING = 4096,
    D3D12_BARRIER_SYNC_NON_PIXEL_SHADING = 8192,
    D3D12_BARRIER_SYNC_EMIT_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO = 16384,
    D3D12_BARRIER_SYNC_CLEAR_UNORDERED_ACCESS_VIEW = 32768,
    D3D12_BARRIER_SYNC_VIDEO_DECODE = 1048576,
    D3D12_BARRIER_SYNC_VIDEO_PROCESS = 2097152,
    D3D12_BARRIER_SYNC_VIDEO_ENCODE = 4194304,
    D3D12_BARRIER_SYNC_BUILD_RAYTRACING_ACCELERATION_STRUCTURE = 8388608,
    D3D12_BARRIER_SYNC_COPY_RAYTRACING_ACCELERATION_STRUCTURE = 16777216,
    D3D12_BARRIER_SYNC_SPLIT = int.MinValue,
}
