#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options1
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS1
{
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
    public BOOL MinMaxFiltering;
    public BOOL ClearViewAlsoSupportsDepthOnlyFormats;
    public BOOL MapOnDefaultBuffers;
}
