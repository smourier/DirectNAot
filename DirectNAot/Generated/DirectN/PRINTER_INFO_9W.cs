namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-9
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_9W
{
    public nint pDevMode;
}
