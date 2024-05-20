#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ns-dxvahd-dxvahd_stream_data
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHD_STREAM_DATA
{
    [MarshalAs(UnmanagedType.U4)]
    public bool Enable;
    public uint OutputIndex;
    public uint InputFrameOrField;
    public uint PastFrames;
    public uint FutureFrames;
    public nint ppPastSurfaces;
    public nint pInputSurface;
    public nint ppFutureSurfaces;
}
