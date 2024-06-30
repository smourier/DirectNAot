#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_device_removed_extended_data
public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA
{
    public D3D12_DRED_FLAGS Flags;
    public nint pHeadAutoBreadcrumbNode;
}
