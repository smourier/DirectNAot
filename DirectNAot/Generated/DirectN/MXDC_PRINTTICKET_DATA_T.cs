namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcprintticketpassthrough
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_PRINTTICKET_DATA_T
{
    public uint dwDataSize;
    public InlineArrayByte1 bData; // variable-length array placeholder
}
