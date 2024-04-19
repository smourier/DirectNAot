﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_codec_configuration_hevc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC
{
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_FLAGS ConfigurationFlags;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MinLumaCodingUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_CUSIZE MaxLumaCodingUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MinLumaTransformUnitSize;
    public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC_TUSIZE MaxLumaTransformUnitSize;
    public byte max_transform_hierarchy_depth_inter;
    public byte max_transform_hierarchy_depth_intra;
}
