namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_frame_statistics
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_FRAME_STATISTICS
{
    public uint PresentCount;
    public uint PresentRefreshCount;
    public uint SyncRefreshCount;
    public long SyncQPCTime;
    public long SyncGPUTime;
}
