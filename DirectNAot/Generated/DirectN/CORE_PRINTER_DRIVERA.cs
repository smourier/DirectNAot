namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/core-printer-driver
[StructLayout(LayoutKind.Sequential)]
public partial struct CORE_PRINTER_DRIVERA
{
    public Guid CoreDriverGUID;
    public FILETIME ftDriverDate;
    public ulong dwlDriverVersion;
    public InlineArrayFoundationCHAR260 szPackageID;
}
