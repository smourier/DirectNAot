namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winbase/ns-winbase-commtimeouts
[StructLayout(LayoutKind.Sequential)]
public partial struct COMMTIMEOUTS
{
    public uint ReadIntervalTimeout;
    public uint ReadTotalTimeoutMultiplier;
    public uint ReadTotalTimeoutConstant;
    public uint WriteTotalTimeoutMultiplier;
    public uint WriteTotalTimeoutConstant;
}
