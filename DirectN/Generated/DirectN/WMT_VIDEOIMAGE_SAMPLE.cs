#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_videoimage_sample
public partial struct WMT_VIDEOIMAGE_SAMPLE
{
    public uint dwMagic;
    public uint cbStruct;
    public uint dwControlFlags;
    public uint dwInputFlagsCur;
    public int lCurMotionXtoX;
    public int lCurMotionYtoX;
    public int lCurMotionXoffset;
    public int lCurMotionXtoY;
    public int lCurMotionYtoY;
    public int lCurMotionYoffset;
    public int lCurBlendCoef1;
    public int lCurBlendCoef2;
    public uint dwInputFlagsPrev;
    public int lPrevMotionXtoX;
    public int lPrevMotionYtoX;
    public int lPrevMotionXoffset;
    public int lPrevMotionXtoY;
    public int lPrevMotionYtoY;
    public int lPrevMotionYoffset;
    public int lPrevBlendCoef1;
    public int lPrevBlendCoef2;
}
