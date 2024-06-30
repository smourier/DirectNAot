#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_encoder_support
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_SUPPORT
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
    public D3D12_VIDEO_ENCODER_SEQUENCE_GOP_STRUCTURE CodecGopSequence;
    public D3D12_VIDEO_ENCODER_RATE_CONTROL RateControl;
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE IntraRefresh;
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionFrameEncoding;
    public uint ResolutionsListCount;
    public nint pResolutionList;
    public uint MaxReferenceFramesInDPB;
    public D3D12_VIDEO_ENCODER_VALIDATION_FLAGS ValidationFlags;
    public D3D12_VIDEO_ENCODER_SUPPORT_FLAGS SupportFlags;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC SuggestedProfile;
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING SuggestedLevel;
    public nint pResolutionDependentSupport;
}
