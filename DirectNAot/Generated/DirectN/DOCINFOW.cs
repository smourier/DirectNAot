namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-docinfow
[StructLayout(LayoutKind.Sequential)]
public partial struct DOCINFOW
{
    public int cbSize;
    public PWSTR lpszDocName;
    public PWSTR lpszOutput;
    public PWSTR lpszDatatype;
    public uint fwType;
}
