#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_meta_command_parameter_stage
public enum D3D12_META_COMMAND_PARAMETER_STAGE
{
    D3D12_META_COMMAND_PARAMETER_STAGE_CREATION = 0,
    D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION = 1,
    D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION = 2,
}
