namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct MONITORINFO
{
    public uint cbSize;
    public FoundationRECT rcMonitor;
    public FoundationRECT rcWork;
    public uint dwFlags;
}
