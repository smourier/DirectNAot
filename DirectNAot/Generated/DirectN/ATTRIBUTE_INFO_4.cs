namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct ATTRIBUTE_INFO_4
{
    public uint dwJobNumberOfPagesPerSide;
    public uint dwDrvNumberOfPagesPerSide;
    public uint dwNupBorderFlags;
    public uint dwJobPageOrderFlags;
    public uint dwDrvPageOrderFlags;
    public uint dwJobNumberOfCopies;
    public uint dwDrvNumberOfCopies;
    public uint dwColorOptimization;
    public short dmPrintQuality;
    public short dmYResolution;
    public uint dwDuplexFlags;
    public uint dwNupDirection;
    public uint dwBookletFlags;
    public uint dwScalingPercentX;
    public uint dwScalingPercentY;
}
