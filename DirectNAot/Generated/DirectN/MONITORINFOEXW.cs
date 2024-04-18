namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-monitorinfoexw
[StructLayout(LayoutKind.Sequential)]
public partial struct MONITORINFOEXW
{
    public MONITORINFO monitorInfo;
    public InlineArraySystemChar32 szDevice;
}
