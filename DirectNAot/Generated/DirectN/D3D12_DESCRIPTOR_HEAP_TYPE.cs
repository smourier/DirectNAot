#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_descriptor_heap_type
public enum D3D12_DESCRIPTOR_HEAP_TYPE
{
    D3D12_DESCRIPTOR_HEAP_TYPE_CBV_SRV_UAV = 0,
    D3D12_DESCRIPTOR_HEAP_TYPE_SAMPLER = 1,
    D3D12_DESCRIPTOR_HEAP_TYPE_RTV = 2,
    D3D12_DESCRIPTOR_HEAP_TYPE_DSV = 3,
    D3D12_DESCRIPTOR_HEAP_TYPE_NUM_TYPES = 4,
}
