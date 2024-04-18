namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-4
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_4W
{
    public PWSTR pPrinterName;
    public PWSTR pServerName;
    public uint Attributes;
}
