#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_CODEC_DATA
{
    public D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE FrameType;
    public D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE CompoundPredictionType;
    public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS InterpolationFilter;
    public D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG FrameRestorationConfig;
    public D3D12_VIDEO_ENCODER_AV1_TX_MODE TxMode;
    public uint SuperResDenominator;
    public uint OrderHint;
    public uint PictureIndex;
    public uint TemporalLayerIndexPlus1;
    public uint SpatialLayerIndexPlus1;
    public InlineArrayD3D12_VIDEO_ENCODER_AV1_REFERENCE_PICTURE_DESCRIPTOR8 ReferenceFramesReconPictureDescriptors;
    public InlineArrayUInt327 ReferenceIndices;
    public uint PrimaryRefFrame;
    public uint RefreshFrameFlags;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG LoopFilter;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_DELTA_CONFIG LoopFilterDelta;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_CONFIG Quantization;
    public D3D12_VIDEO_ENCODER_CODEC_AV1_QUANTIZATION_DELTA_CONFIG QuantizationDelta;
    public D3D12_VIDEO_ENCODER_AV1_CDEF_CONFIG CDEF;
    public uint QPMapValuesCount;
    public nint pRateControlQPMap;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG CustomSegmentation;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MAP CustomSegmentsMap;
}
