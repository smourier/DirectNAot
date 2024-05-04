#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ns-vmr9-vmr9alphabitmap
[StructLayout(LayoutKind.Sequential)]
public partial struct VMR9AlphaBitmap
{
    public uint dwFlags;
    public HDC hdc;
    public nint pDDS;
    public RECT rSrc;
    public VMR9NormalizedRect rDest;
    public float fAlpha;
    public COLORREF clrSrcKey;
    public uint dwFilterMode;
}
