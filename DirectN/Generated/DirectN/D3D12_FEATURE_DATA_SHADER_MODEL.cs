#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_shader_model
public partial struct D3D12_FEATURE_DATA_SHADER_MODEL : IValueGet<D3D_SHADER_MODEL>
{
    public D3D_SHADER_MODEL HighestShaderModel;
    
    readonly D3D_SHADER_MODEL IValueGet<D3D_SHADER_MODEL>.GetValue() => HighestShaderModel;
    readonly object? IValueGet.GetValue() => HighestShaderModel;
}
