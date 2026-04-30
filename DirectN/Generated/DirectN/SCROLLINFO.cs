#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-scrollinfo
public partial struct SCROLLINFO
{
    public uint cbSize;
    public SCROLLINFO_MASK fMask;
    public int nMin;
    public int nMax;
    public uint nPage;
    public int nPos;
    public int nTrackPos;
}
