#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_FENCE_BARRIERS
{
    public uint NodeIndex;
    public D3D12_COMMAND_LIST_TYPE CommandListType;
    public D3D12_FENCE_BARRIERS_TIER FenceBarriersTier;
    public D3D12_FENCE_BARRIERS_SUPPORT_FLAGS SupportFlags;
}
