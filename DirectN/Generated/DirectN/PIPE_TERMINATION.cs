#nullable enable
namespace DirectN;

public partial struct PIPE_TERMINATION
{
    public uint Flags;
    public uint OutsideFactors;
    public uint Weigth;
    public KS_FRAMING_RANGE PhysicalRange;
    public KS_FRAMING_RANGE_WEIGHTED OptimalRange;
    public KS_COMPRESSION Compression;
}
