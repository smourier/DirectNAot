namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ns-strmif-vmralphabitmap
[StructLayout(LayoutKind.Sequential)]
public partial struct VMRALPHABITMAP
{
    public uint dwFlags;
    public HDC hdc;
    public nint pDDS;
    public FoundationRECT rSrc;
    public NORMALIZEDRECT rDest;
    public float fAlpha;
    public COLORREF clrSrcKey;
}
