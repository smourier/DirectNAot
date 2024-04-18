namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_acceleration_structure_prebuild_info
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO
{
    public ulong ResultDataMaxSizeInBytes;
    public ulong ScratchDataSizeInBytes;
    public ulong UpdateScratchDataSizeInBytes;
}
