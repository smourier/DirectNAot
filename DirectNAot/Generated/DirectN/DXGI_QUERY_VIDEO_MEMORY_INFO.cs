namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_4/ns-dxgi1_4-dxgi_query_video_memory_info
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_QUERY_VIDEO_MEMORY_INFO
{
    public ulong Budget;
    public ulong CurrentUsage;
    public ulong AvailableForReservation;
    public ulong CurrentReservation;
}
