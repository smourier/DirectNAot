namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/printer-enum-values
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINTER_ENUM_VALUESA
{
    public PSTR pValueName;
    public uint cbValueName;
    public uint dwType;
    public nint pData;
    public uint cbData;
}
