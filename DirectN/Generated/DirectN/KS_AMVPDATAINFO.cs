#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_AMVPDATAINFO
{
    public uint dwSize;
    public uint dwMicrosecondsPerField;
    public KS_AMVPDIMINFO amvpDimInfo;
    public uint dwPictAspectRatioX;
    public uint dwPictAspectRatioY;
    public BOOL bEnableDoubleClock;
    public BOOL bEnableVACT;
    public BOOL bDataIsInterlaced;
    public int lHalfLinesOdd;
    public BOOL bFieldPolarityInverted;
    public uint dwNumLinesInVREF;
    public int lHalfLinesEven;
    public uint dwReserved1;
}
