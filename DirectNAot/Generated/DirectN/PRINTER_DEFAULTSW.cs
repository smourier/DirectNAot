namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-defaults
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_DEFAULTSW
{
    public PWSTR pDatatype;
    public nint pDevMode;
    public PRINTER_ACCESS_RIGHTS DesiredAccess;
}
