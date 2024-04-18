namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcescapeheader
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_ESCAPE_HEADER_T
{
    public uint cbInput;
    public uint cbOutput;
    public uint opCode;
}
