namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ns-d3d12sdklayers-d3d12_debug_command_list_gpu_based_validation_settings
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_DEBUG_COMMAND_LIST_GPU_BASED_VALIDATION_SETTINGS
{
    public D3D12_GPU_BASED_VALIDATION_SHADER_PATCH_MODE ShaderPatchMode;
}
