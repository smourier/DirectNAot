#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msvidctl/ne-msvidctl-displaysizelist
public enum DisplaySizeList
{
    dslDefaultSize = 0,
    dslSourceSize = 0,
    dslHalfSourceSize = 1,
    dslDoubleSourceSize = 2,
    dslFullScreen = 3,
    dslHalfScreen = 4,
    dslQuarterScreen = 5,
    dslSixteenthScreen = 6,
}
