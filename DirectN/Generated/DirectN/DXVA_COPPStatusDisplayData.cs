#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxva_coppstatusdisplaydata
public partial struct DXVA_COPPStatusDisplayData
{
    public Guid rApp;
    public uint dwFlags;
    public uint DisplayWidth;
    public uint DisplayHeight;
    public uint Format;
    public uint d3dFormat;
    public uint FreqNumerator;
    public uint FreqDenominator;
}
