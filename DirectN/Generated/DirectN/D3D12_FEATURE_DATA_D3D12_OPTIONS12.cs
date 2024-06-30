#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options12
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS12
{
    public D3D12_TRI_STATE MSPrimitivesPipelineStatisticIncludesCulledPrimitives;
    public BOOL EnhancedBarriersSupported;
    public BOOL RelaxedFormatCastingSupported;
}
