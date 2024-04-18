namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_raytracing_geometry_flags
public enum D3D12_RAYTRACING_GEOMETRY_FLAGS
{
    D3D12_RAYTRACING_GEOMETRY_FLAG_NONE = 0,
    D3D12_RAYTRACING_GEOMETRY_FLAG_OPAQUE = 1,
    D3D12_RAYTRACING_GEOMETRY_FLAG_NO_DUPLICATE_ANYHIT_INVOCATION = 2,
}
