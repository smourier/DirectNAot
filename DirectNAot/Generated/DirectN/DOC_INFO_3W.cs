namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/doc-info-3
[StructLayout(LayoutKind.Sequential)]
public partial struct DOC_INFO_3W
{
    public PWSTR pDocName;
    public PWSTR pOutputFile;
    public PWSTR pDatatype;
    public uint dwFlags;
}
