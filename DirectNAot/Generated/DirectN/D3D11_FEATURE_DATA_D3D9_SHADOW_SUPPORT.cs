namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d9_shadow_support
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_D3D9_SHADOW_SUPPORT
{
    [MarshalAs(UnmanagedType.U4)]
    public bool SupportsDepthAsTextureWithLessEqualComparisonFilter;
}
