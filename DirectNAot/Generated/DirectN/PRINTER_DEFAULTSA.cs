namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-defaults
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_DEFAULTSA
{
    public PSTR pDatatype;
    public nint pDevMode;
    public PRINTER_ACCESS_RIGHTS DesiredAccess;
}
