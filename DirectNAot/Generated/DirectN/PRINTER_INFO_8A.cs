namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-8
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_8A
{
    public nint pDevMode;
}
