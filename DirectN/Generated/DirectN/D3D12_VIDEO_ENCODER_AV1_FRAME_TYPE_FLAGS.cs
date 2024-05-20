﻿#nullable enable
namespace DirectN;

[Flags]
public enum D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAGS
{
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_NONE = 0,
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_KEY_FRAME = 1,
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTER_FRAME = 2,
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_INTRA_ONLY_FRAME = 4,
    D3D12_VIDEO_ENCODER_AV1_FRAME_TYPE_FLAG_SWITCH_FRAME = 8,
}
