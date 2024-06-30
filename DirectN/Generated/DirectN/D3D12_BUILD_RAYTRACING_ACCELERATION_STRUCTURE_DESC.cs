#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_build_raytracing_acceleration_structure_desc
public partial struct D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_DESC
{
    public ulong DestAccelerationStructureData;
    public D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS Inputs;
    public ulong SourceAccelerationStructureData;
    public ulong ScratchAccelerationStructureData;
}
