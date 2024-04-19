namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_size_range
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_SIZE_RANGE
{
    public uint MaxWidth;
    public uint MaxHeight;
    public uint MinWidth;
    public uint MinHeight;
}
