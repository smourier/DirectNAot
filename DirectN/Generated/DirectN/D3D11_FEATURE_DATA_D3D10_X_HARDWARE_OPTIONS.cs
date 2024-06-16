#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d10_x_hardware_options
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS
{
    public BOOL ComputeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x;
}
