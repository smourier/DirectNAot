namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/doc-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct DOC_INFO_2A
{
    public PSTR pDocName;
    public PSTR pOutputFile;
    public PSTR pDatatype;
    public uint dwMode;
    public uint JobId;
}
