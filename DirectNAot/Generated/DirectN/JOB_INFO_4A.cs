namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/job-info-4
[StructLayout(LayoutKind.Sequential)]
public partial struct JOB_INFO_4A
{
    public uint JobId;
    public PSTR pPrinterName;
    public PSTR pMachineName;
    public PSTR pUserName;
    public PSTR pDocument;
    public PSTR pNotifyName;
    public PSTR pDatatype;
    public PSTR pPrintProcessor;
    public PSTR pParameters;
    public PSTR pDriverName;
    public nint pDevMode;
    public PSTR pStatus;
    public PSECURITY_DESCRIPTOR pSecurityDescriptor;
    public uint Status;
    public uint Priority;
    public uint Position;
    public uint StartTime;
    public uint UntilTime;
    public uint TotalPages;
    public uint Size;
    public SYSTEMTIME Submitted;
    public uint Time;
    public uint PagesPrinted;
    public int SizeHigh;
}
