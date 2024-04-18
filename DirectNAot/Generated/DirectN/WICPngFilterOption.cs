namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicpngfilteroption
public enum WICPngFilterOption
{
    WICPngFilterUnspecified = 0,
    WICPngFilterNone = 1,
    WICPngFilterSub = 2,
    WICPngFilterUp = 3,
    WICPngFilterAverage = 4,
    WICPngFilterPaeth = 5,
    WICPngFilterAdaptive = 6,
}
