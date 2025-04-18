#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options2
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS2
{
    public BOOL PSSpecifiedStencilRefSupported;
    public BOOL TypedUAVLoadAdditionalFormats;
    public BOOL ROVsSupported;
    public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
    public BOOL MapOnDefaultTextures;
    public BOOL StandardSwizzle;
    public BOOL UnifiedMemoryArchitecture;
}
