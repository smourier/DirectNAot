#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_pipeline_config1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RAYTRACING_PIPELINE_CONFIG1
{
    public uint MaxTraceRecursionDepth;
    public D3D12_RAYTRACING_PIPELINE_FLAGS Flags;
}
