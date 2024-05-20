#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WMDM/wmdmdatetime
[StructLayout(LayoutKind.Sequential)]
public partial struct WMDMDATETIME
{
    public ushort wYear;
    public ushort wMonth;
    public ushort wDay;
    public ushort wHour;
    public ushort wMinute;
    public ushort wSecond;
}
