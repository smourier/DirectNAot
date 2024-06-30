#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-histogramheader
public partial struct HistogramHeader
{
    public uint Size;
    public uint Bins;
    public uint FourCC;
    public uint ChannelMasks;
    public HistogramGrid Grid;
}
