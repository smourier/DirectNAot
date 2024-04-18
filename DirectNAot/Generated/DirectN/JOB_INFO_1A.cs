namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/job-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct JOB_INFO_1A
{
    public uint JobId;
    public PSTR pPrinterName;
    public PSTR pMachineName;
    public PSTR pUserName;
    public PSTR pDocument;
    public PSTR pDatatype;
    public PSTR pStatus;
    public uint Status;
    public uint Priority;
    public uint Position;
    public uint TotalPages;
    public uint PagesPrinted;
    public SYSTEMTIME Submitted;
}
