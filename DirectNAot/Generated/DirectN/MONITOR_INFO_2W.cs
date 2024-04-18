namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/monitor-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct MONITOR_INFO_2W
{
    public PWSTR pName;
    public PWSTR pEnvironment;
    public PWSTR pDLLName;
}
