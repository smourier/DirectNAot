#nullable enable
namespace DirectN;

public partial struct DIRTYRECT_INFO
{
    public uint FrameNumber;
    public uint NumDirtyRects;
    public InlineArrayRECT_1 DirtyRects; // variable-length array placeholder
}
