﻿#nullable enable
namespace DirectN;

[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAGS
{
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_NONE = 0,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_DISABLED = 1,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_Q = 2,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_V = 4,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_Y_H = 8,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_U = 16,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_LF_V = 32,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_REF_FRAME = 64,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_SKIP = 128,
    D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_MODE_FLAG_ALT_GLOBALMV = 256,
}