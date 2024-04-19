namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfapi/ns-mfapi-roi_area
[StructLayout(LayoutKind.Sequential)]
public partial struct ROI_AREA
{
    public FoundationRECT rect;
    public int QPDelta;
}
