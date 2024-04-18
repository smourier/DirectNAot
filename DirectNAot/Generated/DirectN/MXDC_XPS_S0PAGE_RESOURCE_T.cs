namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/mxdcxpss0pageresource
[StructLayout(LayoutKind.Sequential)]
public partial struct MXDC_XPS_S0PAGE_RESOURCE_T
{
    public uint dwSize;
    public uint dwResourceType;
    public InlineArrayByte260 szUri;
    public uint dwDataSize;
    public InlineArrayByte1 bData; // variable-length array placeholder
}
