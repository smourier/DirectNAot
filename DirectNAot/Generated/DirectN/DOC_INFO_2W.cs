namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/doc-info-2
[StructLayout(LayoutKind.Sequential)]
public partial struct DOC_INFO_2W
{
    public PWSTR pDocName;
    public PWSTR pOutputFile;
    public PWSTR pDatatype;
    public uint dwMode;
    public uint JobId;
}
