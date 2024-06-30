#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-drawdibtime
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
