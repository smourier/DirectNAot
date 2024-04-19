namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_motion_estimator_input
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_MOTION_ESTIMATOR_INPUT
{
    public nint pInputTexture2D;
    public uint InputSubresourceIndex;
    public nint pReferenceTexture2D;
    public uint ReferenceSubresourceIndex;
    public nint pHintMotionVectorHeap;
}
