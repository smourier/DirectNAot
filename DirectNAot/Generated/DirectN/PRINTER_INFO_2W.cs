namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_2W
{
    public PWSTR pServerName;
    public PWSTR pPrinterName;
    public PWSTR pShareName;
    public PWSTR pPortName;
    public PWSTR pDriverName;
    public PWSTR pComment;
    public PWSTR pLocation;
    public nint pDevMode;
    public PWSTR pSepFile;
    public PWSTR pPrintProcessor;
    public PWSTR pDatatype;
    public PWSTR pParameters;
    public PSECURITY_DESCRIPTOR pSecurityDescriptor;
    public uint Attributes;
    public uint Priority;
    public uint DefaultPriority;
    public uint StartTime;
    public uint UntilTime;
    public uint Status;
    public uint cJobs;
    public uint AveragePPM;
}
