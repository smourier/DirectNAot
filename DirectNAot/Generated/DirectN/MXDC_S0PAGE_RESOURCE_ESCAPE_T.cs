namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcs0pageresourceescape
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_S0PAGE_RESOURCE_ESCAPE_T
{
    public MXDC_ESCAPE_HEADER_T mxdcEscape;
    public MXDC_XPS_S0PAGE_RESOURCE_T xpsS0PageResourcePassthrough;
}
