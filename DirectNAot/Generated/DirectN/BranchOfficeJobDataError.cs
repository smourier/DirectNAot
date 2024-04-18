namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BranchOfficeJobDataError
{
    public uint LastError;
    public PWSTR pDocumentName;
    public PWSTR pUserName;
    public PWSTR pPrinterName;
    public PWSTR pDataType;
    public long TotalSize;
    public long PrintedSize;
    public uint TotalPages;
    public uint PrintedPages;
    public PWSTR pMachineName;
    public PWSTR pJobError;
    public PWSTR pErrorDescription;
}
