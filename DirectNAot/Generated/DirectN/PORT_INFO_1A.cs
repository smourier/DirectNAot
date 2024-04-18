namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/port-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_INFO_1A
{
    public PSTR pName;
}
