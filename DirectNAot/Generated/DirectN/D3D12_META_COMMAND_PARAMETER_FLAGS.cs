namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ne-d3d12-d3d12_meta_command_parameter_flags
[Flags]
public enum D3D12_META_COMMAND_PARAMETER_FLAGS
{
    D3D12_META_COMMAND_PARAMETER_FLAG_INPUT = 1,
    D3D12_META_COMMAND_PARAMETER_FLAG_OUTPUT = 2,
}
