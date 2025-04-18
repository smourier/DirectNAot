#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_feature_data_d3d12_options3
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS3
{
    public BOOL CopyQueueTimestampQueriesSupported;
    public BOOL CastingFullyTypedFormatSupported;
    public D3D12_COMMAND_LIST_SUPPORT_FLAGS WriteBufferImmediateSupportFlags;
    public D3D12_VIEW_INSTANCING_TIER ViewInstancingTier;
    public BOOL BarycentricsSupported;
}
