#nullable enable
namespace DirectN;

public partial struct DXVAHDETW_VIDEOPROCESSBLTHD
{
    public ulong pObject;
    public ulong pOutputSurface;
    public RECT TargetRect;
    public D3DFORMAT OutputFormat;
    public uint ColorSpace;
    public uint OutputFrame;
    public uint StreamCount;
    public BOOL Enter;
}
