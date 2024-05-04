namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-capstatus
[StructLayout(LayoutKind.Sequential)]
public partial struct CAPSTATUS
{
    public uint uiImageWidth;
    public uint uiImageHeight;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fLiveWindow;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fOverlayWindow;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fScale;
    public POINT ptScroll;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fUsingDefaultPalette;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fAudioHardware;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fCapFileExists;
    public uint dwCurrentVideoFrame;
    public uint dwCurrentVideoFramesDropped;
    public uint dwCurrentWaveSamples;
    public uint dwCurrentTimeElapsedMS;
    public HPALETTE hPalCurrent;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool fCapturingNow;
    public uint dwReturn;
    public uint wNumVideoAllocated;
    public uint wNumAudioAllocated;
}
