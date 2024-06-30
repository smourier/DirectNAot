#nullable enable
namespace DirectN;

public partial struct VBICODECFILTERING_STATISTICS_COMMON_PIN
{
    public uint SRBsProcessed;
    public uint SRBsIgnored;
    public uint SRBsMissing;
    public uint InternalErrors;
    public uint ExternalErrors;
    public uint Discontinuities;
    public uint LineConfidenceAvg;
    public uint BytesOutput;
}
