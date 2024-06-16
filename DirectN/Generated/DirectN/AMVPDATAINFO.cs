#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vptype/ns-vptype-amvpdatainfo
[StructLayout(LayoutKind.Sequential)]
public partial struct AMVPDATAINFO
{
    public uint dwSize;
    public uint dwMicrosecondsPerField;
    public AMVPDIMINFO amvpDimInfo;
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
