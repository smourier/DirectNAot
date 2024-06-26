﻿#nullable enable
namespace DirectN;

[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAGS
{
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_NONE = 0,
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP = 1,
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SMOOTH = 2,
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_EIGHTTAP_SHARP = 4,
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_BILINEAR = 8,
    D3D12_VIDEO_ENCODER_AV1_INTERPOLATION_FILTERS_FLAG_SWITCHABLE = 16,
}
