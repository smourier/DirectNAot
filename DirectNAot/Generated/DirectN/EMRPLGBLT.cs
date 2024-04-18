namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrplgblt
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPLGBLT
{
    public EMR emr;
    public RECTL rclBounds;
    public InlineArrayPOINTL3 aptlDest;
    public int xSrc;
    public int ySrc;
    public int cxSrc;
    public int cySrc;
    public XFORM xformSrc;
    public COLORREF crBkColorSrc;
    public uint iUsageSrc;
    public uint offBmiSrc;
    public uint cbBmiSrc;
    public uint offBitsSrc;
    public uint cbBitsSrc;
    public int xMask;
    public int yMask;
    public uint iUsageMask;
    public uint offBmiMask;
    public uint cbBmiMask;
    public uint offBitsMask;
    public uint cbBitsMask;
}
