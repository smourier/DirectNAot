#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_data
public partial struct DXVAHD_STREAM_DATA
{
    public BOOL Enable;
    public uint OutputIndex;
    public uint InputFrameOrField;
    public uint PastFrames;
    public uint FutureFrames;
    public nint ppPastSurfaces;
    public nint pInputSurface;
    public nint ppFutureSurfaces;
}
