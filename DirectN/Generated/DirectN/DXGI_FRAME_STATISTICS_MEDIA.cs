#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_3/ns-dxgi1_3-dxgi_frame_statistics_media
public partial struct DXGI_FRAME_STATISTICS_MEDIA
{
    public uint PresentCount;
    public uint PresentRefreshCount;
    public uint SyncRefreshCount;
    public long SyncQPCTime;
    public long SyncGPUTime;
    public DXGI_FRAME_PRESENTATION_MODE CompositionMode;
    public uint ApprovedPresentDuration;
}
