namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfoexa
[StructLayout(LayoutKind.Sequential)]
public partial struct MONITORINFOEXA
{
    public MONITORINFO monitorInfo;
    public InlineArrayFoundationCHAR32 szDevice;
}
