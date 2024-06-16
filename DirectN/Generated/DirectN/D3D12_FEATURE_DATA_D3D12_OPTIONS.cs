#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS
{
    public BOOL DoublePrecisionFloatShaderOps;
    public BOOL OutputMergerLogicOp;
    public D3D12_SHADER_MIN_PRECISION_SUPPORT MinPrecisionSupport;
    public D3D12_TILED_RESOURCES_TIER TiledResourcesTier;
    public D3D12_RESOURCE_BINDING_TIER ResourceBindingTier;
    public BOOL PSSpecifiedStencilRefSupported;
    public BOOL TypedUAVLoadAdditionalFormats;
    public BOOL ROVsSupported;
    public D3D12_CONSERVATIVE_RASTERIZATION_TIER ConservativeRasterizationTier;
    public uint MaxGPUVirtualAddressBitsPerResource;
    public BOOL StandardSwizzle64KBSupported;
    public D3D12_CROSS_NODE_SHARING_TIER CrossNodeSharingTier;
    public BOOL CrossAdapterRowMajorTextureSupported;
    public BOOL VPAndRTArrayIndexFromAnyShaderFeedingRasterizerSupportedWithoutGSEmulation;
    public D3D12_RESOURCE_HEAP_TIER ResourceHeapTier;
}
