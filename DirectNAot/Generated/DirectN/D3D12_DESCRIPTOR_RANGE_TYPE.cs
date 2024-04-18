namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_descriptor_range_type
public enum D3D12_DESCRIPTOR_RANGE_TYPE
{
    D3D12_DESCRIPTOR_RANGE_TYPE_SRV = 0,
    D3D12_DESCRIPTOR_RANGE_TYPE_UAV = 1,
    D3D12_DESCRIPTOR_RANGE_TYPE_CBV = 2,
    D3D12_DESCRIPTOR_RANGE_TYPE_SAMPLER = 3,
}
