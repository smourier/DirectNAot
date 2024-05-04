#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_tools_visualization_header
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_TOOLS_VISUALIZATION_HEADER
{
    public D3D12_RAYTRACING_ACCELERATION_STRUCTURE_TYPE Type;
    public uint NumDescs;
}
