#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VBICODECFILTERING_STATISTICS_NABTS
{
    public VBICODECFILTERING_STATISTICS_COMMON Common;
    public uint FECBundleBadLines;
    public uint FECQueueOverflows;
    public uint FECCorrectedLines;
    public uint FECUncorrectableLines;
    public uint BundlesProcessed;
    public uint BundlesSent2IP;
    public uint FilteredLines;
}
