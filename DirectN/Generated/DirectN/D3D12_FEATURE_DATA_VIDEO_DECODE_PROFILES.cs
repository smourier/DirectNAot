﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_feature_data_video_decode_profiles
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES
{
    public uint NodeIndex;
    public uint ProfileCount;
    public nint pProfiles;
}
