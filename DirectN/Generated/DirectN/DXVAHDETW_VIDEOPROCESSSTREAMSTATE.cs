#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVAHDETW_VIDEOPROCESSSTREAMSTATE
{
    public ulong pObject;
    public uint StreamNumber;
    public DXVAHD_STREAM_STATE State;
    public uint DataSize;
    public BOOL SetState;
}
