namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_INFO_1W
{
    public uint Flags;
    public PWSTR pDescription;
    public PWSTR pName;
    public PWSTR pComment;
}
