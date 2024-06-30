#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmralphabitmap
public partial struct VMRALPHABITMAP
{
    public uint dwFlags;
    public HDC hdc;
    public nint pDDS;
    public RECT rSrc;
    public NORMALIZEDRECT rDest;
    public float fAlpha;
    public COLORREF clrSrcKey;
}
