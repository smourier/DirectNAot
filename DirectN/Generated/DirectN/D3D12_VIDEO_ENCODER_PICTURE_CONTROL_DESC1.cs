#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC1
{
    public uint IntraRefreshFrameIndex;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_PICTURE_CONTROL_CODEC_DATA1 PictureControlCodecData;
    public D3D12_VIDEO_ENCODE_REFERENCE_FRAMES ReferenceFrames;
    public D3D12_VIDEO_ENCODER_FRAME_MOTION_VECTORS MotionVectors;
    public D3D12_VIDEO_ENCODER_DIRTY_REGIONS DirtyRects;
    public D3D12_VIDEO_ENCODER_QUANTIZATION_OPAQUE_MAP QuantizationTextureMap;
    public D3D12_VIDEO_ENCODER_FRAME_ANALYSIS FrameAnalysis;
}
