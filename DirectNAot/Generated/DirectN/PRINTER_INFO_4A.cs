namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-4
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_4A
{
    public PSTR pPrinterName;
    public PSTR pServerName;
    public uint Attributes;
}
