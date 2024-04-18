namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DOCUMENTPROPERTYHEADER
{
    public ushort cbSize;
    public ushort Reserved;
    public HANDLE hPrinter;
    public nint pszPrinterName;
    public nint pdmIn;
    public nint pdmOut;
    public uint cbOut;
    public uint fMode;
}
