#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-updatelayeredwindowinfo
public partial struct UPDATELAYEREDWINDOWINFO
{
    public uint cbSize;
    public HDC hdcDst;
    public nint pptDst;
    public nint psize;
    public HDC hdcSrc;
    public nint pptSrc;
    public COLORREF crKey;
    public nint pblend;
    public UPDATE_LAYERED_WINDOW_FLAGS dwFlags;
    public nint prcDirty;
}
