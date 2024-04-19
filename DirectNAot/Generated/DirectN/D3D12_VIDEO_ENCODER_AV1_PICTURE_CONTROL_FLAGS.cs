﻿namespace DirectN;

[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAGS
{
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_NONE = 0,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_ERROR_RESILIENT_MODE = 1,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_DISABLE_CDF_UPDATE = 2,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_PALETTE_ENCODING = 4,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_SKIP_MODE = 8,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_FRAME_REFERENCE_MOTION_VECTORS = 16,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_FORCE_INTEGER_MOTION_VECTORS = 32,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ALLOW_INTRA_BLOCK_COPY = 64,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_USE_SUPER_RESOLUTION = 128,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_DISABLE_FRAME_END_UPDATE_CDF = 256,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_FRAME_SEGMENTATION_AUTO = 512,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_FRAME_SEGMENTATION_CUSTOM = 1024,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ENABLE_WARPED_MOTION = 2048,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_REDUCED_TX_SET = 4096,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_MOTION_MODE_SWITCHABLE = 8192,
    D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_FLAG_ALLOW_HIGH_PRECISION_MV = 16384,
}
