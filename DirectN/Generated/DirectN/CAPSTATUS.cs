#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-capstatus
public partial struct CAPSTATUS
{
    public uint uiImageWidth;
    public uint uiImageHeight;
    public BOOL fLiveWindow;
    public BOOL fOverlayWindow;
    public BOOL fScale;
    public POINT ptScroll;
    public BOOL fUsingDefaultPalette;
    public BOOL fAudioHardware;
    public BOOL fCapFileExists;
    public uint dwCurrentVideoFrame;
    public uint dwCurrentVideoFramesDropped;
    public uint dwCurrentWaveSamples;
    public uint dwCurrentTimeElapsedMS;
    public HPALETTE hPalCurrent;
    public BOOL fCapturingNow;
    public uint dwReturn;
    public uint wNumVideoAllocated;
    public uint wNumAudioAllocated;
}
