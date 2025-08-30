#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_resource_uav_barrier
public partial struct D3D12_RESOURCE_UAV_BARRIER : IValueGet<nint>
{
    public nint pResource;
    
    readonly nint IValueGet<nint>.GetValue() => pResource;
    readonly object? IValueGet.GetValue() => pResource;
}
