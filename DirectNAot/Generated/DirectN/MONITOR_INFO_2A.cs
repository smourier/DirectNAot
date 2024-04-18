namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/monitor-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct MONITOR_INFO_2A
{
    public PSTR pName;
    public PSTR pEnvironment;
    public PSTR pDLLName;
}
