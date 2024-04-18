namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/doc-info-3
[StructLayout(LayoutKind.Sequential)]
public partial struct DOC_INFO_3A
{
    public PSTR pDocName;
    public PSTR pOutputFile;
    public PSTR pDatatype;
    public uint dwFlags;
}
