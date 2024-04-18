namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_1A
{
    public uint Flags;
    public PSTR pDescription;
    public PSTR pName;
    public PSTR pComment;
}
