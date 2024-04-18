namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcgetfilenamedata
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_GET_FILENAME_DATA_T
{
    public uint cbOutput;
    public InlineArraySystemChar1 wszData; // variable-length array placeholder
}
