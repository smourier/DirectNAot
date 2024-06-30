﻿#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG
{
    public uint NodeIndex;
    public D3D12_VIDEO_ENCODER_CODEC Codec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING Level;
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE SubregionMode;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC FrameResolution;
    public D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT CodecSupport;
    public BOOL IsSupported;
}
