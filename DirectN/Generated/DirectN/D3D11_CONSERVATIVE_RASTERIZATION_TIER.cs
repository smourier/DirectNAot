#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_conservative_rasterization_tier
public enum D3D11_CONSERVATIVE_RASTERIZATION_TIER
{
    D3D11_CONSERVATIVE_RASTERIZATION_NOT_SUPPORTED = 0,
    D3D11_CONSERVATIVE_RASTERIZATION_TIER_1 = 1,
    D3D11_CONSERVATIVE_RASTERIZATION_TIER_2 = 2,
    D3D11_CONSERVATIVE_RASTERIZATION_TIER_3 = 3,
}
