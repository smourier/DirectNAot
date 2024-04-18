namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/driver-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct DRIVER_INFO_1A
{
    public PSTR pName;
}
