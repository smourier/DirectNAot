namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcprintticketescape
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_PRINTTICKET_ESCAPE_T
{
    public MXDC_ESCAPE_HEADER_T mxdcEscape;
    public MXDC_PRINTTICKET_DATA_T printTicketData;
}
