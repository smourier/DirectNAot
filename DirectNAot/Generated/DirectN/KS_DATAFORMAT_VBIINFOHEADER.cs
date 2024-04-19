namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KS_DATAFORMAT_VBIINFOHEADER
{
    public KSDATAFORMAT DataFormat;
    public KS_VBIINFOHEADER VBIInfoHeader;
}
