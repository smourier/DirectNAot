#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-histogramdataheader
public partial struct HistogramDataHeader
{
    public uint Size;
    public uint ChannelMask;
    public uint Linear;
}
