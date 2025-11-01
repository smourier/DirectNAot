#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS1
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;
    public BOOL IsSupported;
    public uint CompressedBitstreamBufferAccessAlignment;
    public uint EncoderMetadataBufferAccessAlignment;
    public uint MaxEncoderOutputMetadataBufferSize;
    public D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS OptionalMetadata;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION CodecConfiguration;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncoderOutputMetadataQPMapTextureDimensions;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncoderOutputMetadataSATDMapTextureDimensions;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncoderOutputMetadataBitAllocationMapTextureDimensions;
    public uint EncoderOutputMetadataFramePSNRComponentsNumber;
    public uint EncoderOutputMetadataSubregionsPSNRComponentsNumber;
    public uint EncoderOutputMetadataSubregionsPSNRResolvedMetadataBufferSize;
}
