#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_INPUT_MAP_DATA_MOTION_VECTORS
{
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_SEARCH_MODE_CONFIG MotionSearchModeConfiguration;
    public uint NumHintsPerPixel;
    public nint ppMotionVectorMaps;
    public nint pMotionVectorMapsSubresources;
    public nint ppMotionVectorMapsMetadata;
    public nint pMotionVectorMapsMetadataSubresources;
    public D3D12_VIDEO_ENCODER_FRAME_INPUT_MOTION_UNIT_PRECISION MotionUnitPrecision;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1 PictureControlConfiguration;
}
