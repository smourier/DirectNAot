#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-histogramblobheader
public partial struct HistogramBlobHeader
{
    public uint Size;
    public uint Histograms;
}
