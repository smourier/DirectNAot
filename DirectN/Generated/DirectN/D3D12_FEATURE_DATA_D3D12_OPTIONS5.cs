﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options5
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS5
{
    public BOOL SRVOnlyTiledResourceTier3;
    public D3D12_RENDER_PASS_TIER RenderPassesTier;
    public D3D12_RAYTRACING_TIER RaytracingTier;
}
