namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/port-info-3
[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_INFO_3A
{
    public uint dwStatus;
    public PSTR pszStatus;
    public uint dwSeverity;
}
