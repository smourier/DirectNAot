﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ne-d3d12video-d3d12_video_encoder_encode_error_flags
[Flags]
public enum D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS
{
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_NO_ERROR = 0,
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_CODEC_PICTURE_CONTROL_NOT_SUPPORTED = 1,
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_SUBREGION_LAYOUT_CONFIGURATION_NOT_SUPPORTED = 2,
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_REFERENCE_PICTURES = 4,
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_RECONFIGURATION_REQUEST_NOT_SUPPORTED = 8,
    D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_METADATA_BUFFER_SOURCE = 16,
}
