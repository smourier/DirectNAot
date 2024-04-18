namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/minwinbase/ns-minwinbase-systemtime
[StructLayout(LayoutKind.Sequential)]
public partial struct SYSTEMTIME
{
    public ushort wYear;
    public ushort wMonth;
    public ushort wDayOfWeek;
    public ushort wDay;
    public ushort wHour;
    public ushort wMinute;
    public ushort wSecond;
    public ushort wMilliseconds;
}
