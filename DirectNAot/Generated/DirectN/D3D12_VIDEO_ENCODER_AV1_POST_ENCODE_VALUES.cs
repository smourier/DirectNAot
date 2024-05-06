#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES
{
    public ulong CompoundPredictionType;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG LoopFilter;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG LoopFilterDelta;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG Quantization;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG QuantizationDelta;
    public D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG CDEF;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG SegmentationConfig;
    public ulong PrimaryRefFrame;
    public InlineArrayUInt64_7 ReferenceIndices;
}
