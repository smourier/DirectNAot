﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_motion_estimator_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_MOTION_ESTIMATOR_DESC
{
    public uint NodeMask;
    public DXGI_FORMAT InputFormat;
    public D3D12_VIDEO_MOTION_ESTIMATOR_SEARCH_BLOCK_SIZE BlockSize;
    public D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION Precision;
    public D3D12_VIDEO_SIZE_RANGE SizeRange;
}
