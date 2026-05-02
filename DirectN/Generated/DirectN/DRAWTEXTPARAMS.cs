#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-drawtextparams
public partial struct DRAWTEXTPARAMS
{
    public uint cbSize;
    public int iTabLength;
    public int iLeftMargin;
    public int iRightMargin;
    public uint uiLengthDrawn;
}
