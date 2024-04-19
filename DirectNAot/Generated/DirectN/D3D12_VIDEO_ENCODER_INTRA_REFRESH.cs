namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_encoder_intra_refresh
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_ENCODER_INTRA_REFRESH
{
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE Mode;
    public uint IntraRefreshDuration;
}
