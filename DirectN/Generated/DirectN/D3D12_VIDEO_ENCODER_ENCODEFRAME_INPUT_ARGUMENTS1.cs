#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS1
{
    public D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC SequenceControlDesc;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1 PictureControlDesc;
    public nint pInputFrame;
    public uint InputFrameSubresource;
    public uint CurrentFrameBitstreamMetadataSize;
    public D3D12_VIDEO_ENCODER_OPTIONAL_METADATA_ENABLE_FLAGS OptionalMetadata;
}
