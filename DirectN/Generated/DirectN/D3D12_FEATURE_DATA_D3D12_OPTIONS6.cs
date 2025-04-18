﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS6
{
    public BOOL AdditionalShadingRatesSupported;
    public BOOL PerPrimitiveShadingRateSupportedWithViewportIndexing;
    public D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier;
    public uint ShadingRateImageTileSize;
    public BOOL BackgroundProcessingSupported;
}
