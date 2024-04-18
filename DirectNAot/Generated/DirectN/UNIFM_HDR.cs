namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct UNIFM_HDR
{
    public uint dwSize;
    public uint dwVersion;
    public uint ulDefaultCodepage;
    public int lGlyphSetDataRCID;
    public uint loUnidrvInfo;
    public uint loIFIMetrics;
    public uint loExtTextMetric;
    public uint loWidthTable;
    public uint loKernPair;
    public InlineArrayUInt322 dwReserved;
}
