namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-am_dvd_renderstatus
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVD_RENDERSTATUS
{
    public HRESULT hrVPEStatus;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bDvdVolInvalid;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bDvdVolUnknown;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bNoLine21In;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bNoLine21Out;
    public int iNumStreams;
    public int iNumStreamsFailed;
    public uint dwFailedStreamsFlag;
}
