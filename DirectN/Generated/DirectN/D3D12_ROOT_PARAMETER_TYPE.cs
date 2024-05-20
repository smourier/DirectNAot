#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_root_parameter_type
public enum D3D12_ROOT_PARAMETER_TYPE
{
    D3D12_ROOT_PARAMETER_TYPE_DESCRIPTOR_TABLE = 0,
    D3D12_ROOT_PARAMETER_TYPE_32BIT_CONSTANTS = 1,
    D3D12_ROOT_PARAMETER_TYPE_CBV = 2,
    D3D12_ROOT_PARAMETER_TYPE_SRV = 3,
    D3D12_ROOT_PARAMETER_TYPE_UAV = 4,
}
