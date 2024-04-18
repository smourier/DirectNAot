namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-drawtextparams
[StructLayout(LayoutKind.Sequential)]
public partial struct DRAWTEXTPARAMS
{
    public uint cbSize;
    public int iTabLength;
    public int iLeftMargin;
    public int iRightMargin;
    public uint uiLengthDrawn;
}
