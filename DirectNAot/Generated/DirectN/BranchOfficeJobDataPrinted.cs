namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BranchOfficeJobDataPrinted
{
    public uint Status;
    public PWSTR pDocumentName;
    public PWSTR pUserName;
    public PWSTR pMachineName;
    public PWSTR pPrinterName;
    public PWSTR pPortName;
    public long Size;
    public uint TotalPages;
}
