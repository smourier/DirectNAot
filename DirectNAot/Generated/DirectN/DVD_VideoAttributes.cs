namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-dvd_videoattributes
[StructLayout(LayoutKind.Sequential)]
public partial struct DVD_VideoAttributes
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fPanscanPermitted;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fLetterboxPermitted;
    public uint ulAspectX;
    public uint ulAspectY;
    public uint ulFrameRate;
    public uint ulFrameHeight;
    public DVD_VIDEO_COMPRESSION Compression;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fLine21Field1InGOP;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fLine21Field2InGOP;
    public uint ulSourceResolutionX;
    public uint ulSourceResolutionY;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fIsSourceLetterboxed;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fIsFilmMode;
}
