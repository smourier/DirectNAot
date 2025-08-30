#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_doubles
public partial struct D3D11_FEATURE_DATA_DOUBLES : IValueGet<BOOL>
{
    public BOOL DoublePrecisionFloatShaderOps;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => DoublePrecisionFloatShaderOps;
    readonly object? IValueGet.GetValue() => DoublePrecisionFloatShaderOps;
}
