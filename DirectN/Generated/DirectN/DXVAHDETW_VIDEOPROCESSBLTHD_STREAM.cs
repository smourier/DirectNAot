#nullable enable
namespace DirectN;

public partial struct DXVAHDETW_VIDEOPROCESSBLTHD_STREAM
{
    public ulong pObject;
    public ulong pInputSurface;
    public RECT SourceRect;
    public RECT DestinationRect;
    public D3DFORMAT InputFormat;
    public DXVAHD_FRAME_FORMAT FrameFormat;
    public uint ColorSpace;
    public uint StreamNumber;
    public uint OutputIndex;
    public uint InputFrameOrField;
    public uint PastFrames;
    public uint FutureFrames;
}
