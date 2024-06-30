#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-roi_area
public partial struct ROI_AREA
{
    public RECT rect;
    public int QPDelta;
}
