namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrsetdibitstodevice
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRSETDIBITSTODEVICE
{
    public EMR emr;
    public RECTL rclBounds;
    public int xDest;
    public int yDest;
    public int xSrc;
    public int ySrc;
    public int cxSrc;
    public int cySrc;
    public uint offBmiSrc;
    public uint cbBmiSrc;
    public uint offBitsSrc;
    public uint cbBitsSrc;
    public uint iUsageSrc;
    public uint iStartScan;
    public uint cScans;
}
