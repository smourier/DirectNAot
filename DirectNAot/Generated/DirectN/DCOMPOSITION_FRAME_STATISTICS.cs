#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ns-dcomptypes-dcomposition_frame_statistics
[StructLayout(LayoutKind.Sequential)]
public partial struct DCOMPOSITION_FRAME_STATISTICS
{
    public long lastFrameTime;
    public DXGI_RATIONAL currentCompositionRate;
    public long currentTime;
    public long timeFrequency;
    public long nextEstimatedFrameTime;
}
