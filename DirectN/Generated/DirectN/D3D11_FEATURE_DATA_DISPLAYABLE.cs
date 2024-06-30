#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_displayable
public partial struct D3D11_FEATURE_DATA_DISPLAYABLE
{
    public BOOL DisplayableTexture;
    public D3D11_SHARED_RESOURCE_TIER SharedResourceTier;
}
