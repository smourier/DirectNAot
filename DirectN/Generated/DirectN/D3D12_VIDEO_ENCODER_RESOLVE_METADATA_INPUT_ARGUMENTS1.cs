#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS1
{
    public D3D12_VIDEO_ENCODER_CODEC EncoderCodec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncoderProfile;
    public DXGI_FORMAT EncoderInputFormat;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncodedPictureEffectiveResolution;
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER HWLayoutMetadata;
    public D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS OptionalMetadata;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
}
