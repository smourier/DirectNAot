namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_buskey
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVDCOPY_BUSKEY
{
    public InlineArrayByte5 BusKey;
    public InlineArrayByte1 Reserved; // variable-length array placeholder
}
