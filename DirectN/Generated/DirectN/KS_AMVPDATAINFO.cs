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
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bEnableDoubleClock;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bEnableVACT;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bDataIsInterlaced;
    public int lHalfLinesOdd;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bFieldPolarityInverted;
    public uint dwNumLinesInVREF;
    public int lHalfLinesEven;
    public uint dwReserved1;
}
