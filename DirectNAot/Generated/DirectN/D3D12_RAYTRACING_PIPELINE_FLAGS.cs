#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_raytracing_pipeline_flags
[Flags]
public enum D3D12_RAYTRACING_PIPELINE_FLAGS
{
    D3D12_RAYTRACING_PIPELINE_FLAG_NONE = 0,
    D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_TRIANGLES = 256,
    D3D12_RAYTRACING_PIPELINE_FLAG_SKIP_PROCEDURAL_PRIMITIVES = 512,
}
