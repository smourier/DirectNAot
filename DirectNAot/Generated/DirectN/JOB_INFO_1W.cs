namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/job-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct JOB_INFO_1W
{
    public uint JobId;
    public PWSTR pPrinterName;
    public PWSTR pMachineName;
    public PWSTR pUserName;
    public PWSTR pDocument;
    public PWSTR pDatatype;
    public PWSTR pStatus;
    public uint Status;
    public uint Priority;
    public uint Position;
    public uint TotalPages;
    public uint PagesPrinted;
    public SYSTEMTIME Submitted;
}
