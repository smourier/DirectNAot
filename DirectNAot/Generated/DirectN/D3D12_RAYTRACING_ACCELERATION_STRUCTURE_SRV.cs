namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_acceleration_structure_srv
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV
{
    public ulong Location;
}
