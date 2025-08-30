#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d9_options
public partial struct D3D11_FEATURE_DATA_D3D9_OPTIONS : IValueGet<BOOL>
{
    public BOOL FullNonPow2TextureSupport;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => FullNonPow2TextureSupport;
    readonly object? IValueGet.GetValue() => FullNonPow2TextureSupport;
}
