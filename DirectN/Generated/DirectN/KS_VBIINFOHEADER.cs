#nullable enable
namespace DirectN;

public partial struct KS_VBIINFOHEADER
{
    public uint StartLine;
    public uint EndLine;
    public uint SamplingFrequency;
    public uint MinLineStartTime;
    public uint MaxLineStartTime;
    public uint ActualLineStartTime;
    public uint ActualLineEndTime;
    public uint VideoStandard;
    public uint SamplesPerLine;
    public uint StrideInBytes;
    public uint BufferSize;
}
