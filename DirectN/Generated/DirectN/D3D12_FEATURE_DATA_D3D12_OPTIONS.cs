#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool DoublePrecisionFloatShaderOps;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool OutputMergerLogicOp;
    public D3D12_SHADER_MIN_PRECISION_SUPPORT MinPrecisionSupport;
    public D3D12_TILED_RESOURCES_TIER TiledResourcesTier;
    public D3D12_RESOURCE_BINDING_TIER ResourceBindingTier;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PSSpecifiedStencilRefSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool TypedUAVLoadAdditionalFormats;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ROVsSupported;
    public D3D12_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
    public uint MaxGPUVirtualAddressBitsPerResource;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool StandardSwizzle64KBSupported;
    public D3D12_CROSS_NODE_SHARING_TIER CrossNodeSharingTier;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool CrossAdapterRowMajorTextureSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;
    public D3D12_RESOURCE_HEAP_TIER ResourceHeapTier;
}
