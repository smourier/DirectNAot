#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-histogramgrid
public partial struct HistogramGrid
{
    public uint Width;
    public uint Height;
    public RECT Region;
}
