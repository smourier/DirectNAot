#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_shader_min_precision_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_SHADER_MIN_PRECISION_SUPPORT
{
    public uint PixelShaderMinPrecision;
    public uint AllOtherShaderStagesMinPrecision;
}
