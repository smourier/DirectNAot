﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_heap_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_HEAP_DESC
{
    public uint NodeMask;
    public D3D12_VIDEO_ENCODER_HEAP_FLAGS Flags;
    public D3D12_VIDEO_ENCODER_CODEC EncodeCodec;
    public D3D12_VIDEO_ENCODER_PROFILE_DESC EncodeProfile;
    public D3D12_VIDEO_ENCODER_LEVEL_SETTING EncodeLevel;
    public uint ResolutionsListCount;
    public nint pResolutionList;
}
