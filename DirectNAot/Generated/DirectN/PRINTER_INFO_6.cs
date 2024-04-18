namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-6
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_6
{
    public uint dwStatus;
}
