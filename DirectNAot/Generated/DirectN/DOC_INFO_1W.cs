namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/doc-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct DOC_INFO_1W
{
    public PWSTR pDocName;
    public PWSTR pOutputFile;
    public PWSTR pDatatype;
}
