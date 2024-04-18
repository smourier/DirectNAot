namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-enum-values
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_ENUM_VALUESW
{
    public PWSTR pValueName;
    public uint cbValueName;
    public uint dwType;
    public nint pData;
    public uint cbData;
}
