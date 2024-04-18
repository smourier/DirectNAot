namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-3
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_3
{
    public PSECURITY_DESCRIPTOR pSecurityDescriptor;
}
