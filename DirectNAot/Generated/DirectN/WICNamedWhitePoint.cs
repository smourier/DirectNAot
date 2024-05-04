#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicnamedwhitepoint
public enum WICNamedWhitePoint
{
    WICWhitePointDefault = 1,
    WICWhitePointDaylight = 2,
    WICWhitePointCloudy = 4,
    WICWhitePointShade = 8,
    WICWhitePointTungsten = 16,
    WICWhitePointFluorescent = 32,
    WICWhitePointFlash = 64,
    WICWhitePointUnderwater = 128,
    WICWhitePointCustom = 256,
    WICWhitePointAutoWhiteBalance = 512,
    WICWhitePointAsShot = 1,
}
