#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_HEAP_DESC1
{
    public uint NodeMask;
    public D3D12_VIDEO_ENCODER_HEAP_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING EncodeLevel;
    public uint ResolutionsListCount;
    public nint pResolutionList;
    public uint Pow2DownscaleFactor;
}
