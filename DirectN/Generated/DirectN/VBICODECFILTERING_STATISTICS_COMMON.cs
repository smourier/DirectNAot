#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VBICODECFILTERING_STATISTICS_COMMON
{
    public uint InputSRBsProcessed;
    public uint OutputSRBsProcessed;
    public uint SRBsIgnored;
    public uint InputSRBsMissing;
    public uint OutputSRBsMissing;
    public uint OutputFailures;
    public uint InternalErrors;
    public uint ExternalErrors;
    public uint InputDiscontinuities;
    public uint DSPFailures;
    public uint TvTunerChanges;
    public uint VBIHeaderChanges;
    public uint LineConfidenceAvg;
    public uint BytesOutput;
}
