#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d9_options1
public partial struct D3D11_FEATURE_DATA_D3D9_OPTIONS1
{
    public BOOL FullNonPow2TextureSupported;
    public BOOL DepthAsTextureWithLessEqualComparisonFilterSupported;
    public BOOL SimpleInstancingSupported;
    public BOOL TextureCubeFaceRenderTargetWithNonCubeDepthStencilSupported;
}
