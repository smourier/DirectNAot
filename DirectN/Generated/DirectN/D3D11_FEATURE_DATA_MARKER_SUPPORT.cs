#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_marker_support
public partial struct D3D11_FEATURE_DATA_MARKER_SUPPORT : IValueGet<BOOL>
{
    public BOOL Profile;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => Profile;
    readonly object? IValueGet.GetValue() => Profile;
}
