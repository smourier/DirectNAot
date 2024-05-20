#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-docinfoa
[StructLayout(LayoutKind.Sequential)]
public partial struct DOCINFOA
{
    public int cbSize;
    public PSTR lpszDocName;
    public PSTR lpszOutput;
    public PSTR lpszDatatype;
    public uint fwType;
}
