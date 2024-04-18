namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTPROCESSOROPENDATA
{
    public nint pDevMode;
    public PWSTR pDatatype;
    public PWSTR pParameters;
    public PWSTR pDocumentName;
    public uint JobId;
    public PWSTR pOutputFile;
    public PWSTR pPrinterName;
}
