namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-icdrawbegin
[StructLayout(LayoutKind.Sequential)]
public partial struct ICDRAWBEGIN
{
    public uint dwFlags;
    public HPALETTE hpal;
    public HWND hwnd;
    public HDC hdc;
    public int xDst;
    public int yDst;
    public int dxDst;
    public int dyDst;
    public nint lpbi;
    public int xSrc;
    public int ySrc;
    public int dxSrc;
    public int dySrc;
    public uint dwRate;
    public uint dwScale;
}
