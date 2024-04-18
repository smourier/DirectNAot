namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-5
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_5A
{
    public PSTR pPrinterName;
    public PSTR pPortName;
    public uint Attributes;
    public uint DeviceNotSelectedTimeout;
    public uint TransmissionRetryTimeout;
}
