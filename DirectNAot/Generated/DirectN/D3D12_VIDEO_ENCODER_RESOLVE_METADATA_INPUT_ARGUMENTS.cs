﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_resolve_metadata_input_arguments
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_RESOLVE_METADATA_INPUT_ARGUMENTS
{
    public D3D12_VIDEO_ENCODER_CODEC EncoderCodec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncoderProfile;
    public DXGI_FORMAT EncoderInputFormat;
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC EncodedPictureEffectiveResolution;
    public D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER HWLayoutMetadata;
}
