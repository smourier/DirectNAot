#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ns-dwrite_1-dwrite_caret_metrics
public partial struct DWRITE_CARET_METRICS
{
    public short slopeRise;
    public short slopeRun;
    public short offset;
}
