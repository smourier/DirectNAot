namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12video/ns-d3d12video-d3d12_video_process_filter_range
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_VIDEO_PROCESS_FILTER_RANGE
{
    public int Minimum;
    public int Maximum;
    public int Default;
    public float Multiplier;
}
