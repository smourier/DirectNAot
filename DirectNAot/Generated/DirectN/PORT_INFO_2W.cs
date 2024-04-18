namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/port-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_INFO_2W
{
    public PWSTR pPortName;
    public PWSTR pMonitorName;
    public PWSTR pDescription;
    public uint fPortType;
    public uint Reserved;
}
