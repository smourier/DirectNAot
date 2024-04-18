namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/monitor-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct MONITOR_INFO_1W
{
    public PWSTR pName;
}
