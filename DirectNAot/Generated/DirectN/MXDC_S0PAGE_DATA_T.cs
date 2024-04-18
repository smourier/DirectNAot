namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcs0pagedata
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_S0PAGE_DATA_T
{
    public uint dwSize;
    public InlineArrayByte1 bData; // variable-length array placeholder
}
