namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/core-printer-driver
[StructLayout(LayoutKind.Sequential)]
public partial struct CORE_PRINTER_DRIVERW
{
    public Guid CoreDriverGUID;
    public FILETIME ftDriverDate;
    public ulong dwlDriverVersion;
    public InlineArraySystemChar260 szPackageID;
}
