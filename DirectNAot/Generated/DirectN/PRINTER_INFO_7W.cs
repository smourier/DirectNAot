namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-7
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_7W
{
    public PWSTR pszObjectGUID;
    public uint dwAction;
}
