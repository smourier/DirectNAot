namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvdmedia/ns-dvdmedia-am_dvdcopy_chlgkey
[StructLayout(LayoutKind.Sequential)]
public partial struct AM_DVDCOPY_CHLGKEY
{
    public InlineArrayByte10 ChlgKey;
    public InlineArrayByte2 Reserved;
}
