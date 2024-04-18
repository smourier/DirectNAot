namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcs0pagepassthroughescape
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_S0PAGE_PASSTHROUGH_ESCAPE_T
{
    public MXDC_ESCAPE_HEADER_T mxdcEscape;
    public MXDC_S0PAGE_DATA_T xpsS0PageData;
}
