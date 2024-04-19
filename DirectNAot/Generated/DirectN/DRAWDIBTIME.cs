namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-drawdibtime
[StructLayout(LayoutKind.Sequential)]
public partial struct DRAWDIBTIME
{
    public int timeCount;
    public int timeDraw;
    public int timeDecompress;
    public int timeDither;
    public int timeStretch;
    public int timeBlt;
    public int timeSetDIBits;
}
