﻿namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_AV1_CODEC_CONFIGURATION_SUPPORT
{
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS SupportedFeatureFlags;
    public D3D12_VIDEO_ENCODER_AV1_FEATURE_FLAGS RequiredFeatureFlags;
    public D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS SupportedInterpolationFilters;
    public InlineArrayD3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS9 SupportedRestorationParams;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS SupportedSegmentationModes;
    public InlineArrayD3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS4 SupportedTxModes;
    public D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_BLOCK_SIZE SegmentationBlockSize;
    public D3D12_VIDEO_ENCODER_AV1_POST_ENCODE_VALUES_FLAGS PostEncodeValuesFlags;
    public uint MaxTemporalLayers;
    public uint MaxSpatialLayers;
}
