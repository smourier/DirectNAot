namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/job-info-4
[StructLayout(LayoutKind.Sequential)]
public partial struct JOB_INFO_4W
{
    public uint JobId;
    public PWSTR pPrinterName;
    public PWSTR pMachineName;
    public PWSTR pUserName;
    public PWSTR pDocument;
    public PWSTR pNotifyName;
    public PWSTR pDatatype;
    public PWSTR pPrintProcessor;
    public PWSTR pParameters;
    public PWSTR pDriverName;
    public nint pDevMode;
    public PWSTR pStatus;
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
