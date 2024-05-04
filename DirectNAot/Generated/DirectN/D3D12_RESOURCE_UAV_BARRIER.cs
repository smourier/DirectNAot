#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_resource_uav_barrier
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_RESOURCE_UAV_BARRIER
{
    public nint pResource;
}
