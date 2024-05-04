#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr9/ns-evr9-mfvideoalphabitmapparams
[StructLayout(LayoutKind.Sequential)]
public partial struct MFVideoAlphaBitmapParams
{
    public uint dwFlags;
    public COLORREF clrSrcKey;
    public RECT rcSrc;
    public MFVideoNormalizedRect nrcDest;
    public float fAlpha;
    public uint dwFilterMode;
}
