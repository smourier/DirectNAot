namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DEVICEPROPERTYHEADER
{
    public ushort cbSize;
    public ushort Flags;
    public HANDLE hPrinter;
    public nint pszPrinterName;
}
