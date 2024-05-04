#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options6
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS6
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AdditionalShadingRatesSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PerPrimitiveShadingRateSupportedWithViewportIndexing;
    public D3D12_VARIABLE_SHADING_RATE_TIER VariableShadingRateTier;
    public uint ShadingRateImageTileSize;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool BackgroundProcessingSupported;
}
