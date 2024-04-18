namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_2A
{
    public PSTR pServerName;
    public PSTR pPrinterName;
    public PSTR pShareName;
    public PSTR pPortName;
    public PSTR pDriverName;
    public PSTR pComment;
    public PSTR pLocation;
    public nint pDevMode;
    public PSTR pSepFile;
    public PSTR pPrintProcessor;
    public PSTR pDatatype;
    public PSTR pParameters;
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
