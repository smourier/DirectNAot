namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_filter_reduction_type
public enum D3D12_FILTER_REDUCTION_TYPE
{
    D3D12_FILTER_REDUCTION_TYPE_STANDARD = 0,
    D3D12_FILTER_REDUCTION_TYPE_COMPARISON = 1,
    D3D12_FILTER_REDUCTION_TYPE_MINIMUM = 2,
    D3D12_FILTER_REDUCTION_TYPE_MAXIMUM = 3,
}
