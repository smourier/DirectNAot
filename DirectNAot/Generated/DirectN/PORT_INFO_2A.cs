namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/port-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_INFO_2A
{
    public PSTR pPortName;
    public PSTR pMonitorName;
    public PSTR pDescription;
    public uint fPortType;
    public uint Reserved;
}
