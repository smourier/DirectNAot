#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options2
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS2
{
    [MarshalAs(UnmanagedType.U4)]
    public bool PSSpecifiedStencilRefSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool TypedUAVLoadAdditionalFormats;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ROVsSupported;
    public D3D11_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
    public D3D11_TILED_RESOURCES_TIER TiledResourcesTier;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MapOnDefaultTextures;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool StandardSwizzle;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool UnifiedMemoryArchitecture;
}
