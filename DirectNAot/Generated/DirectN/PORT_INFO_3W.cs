namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/port-info-3
[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_INFO_3W
{
    public uint dwStatus;
    public PWSTR pszStatus;
    public uint dwSeverity;
}
