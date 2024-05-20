#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d9_options1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_D3D9_OPTIONS1
{
    [MarshalAs(UnmanagedType.U4)]
    public bool FullNonPow2TextureSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DepthAsTextureWithLessEqualComparisonFilterSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool SimpleInstancingSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
}
