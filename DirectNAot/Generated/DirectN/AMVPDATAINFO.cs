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
