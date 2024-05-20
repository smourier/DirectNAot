#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicbitmapinterpolationmode
public enum WICBitmapInterpolationMode
{
    WICBitmapInterpolationModeNearestNeighbor = 0,
    WICBitmapInterpolationModeLinear = 1,
    WICBitmapInterpolationModeCubic = 2,
    WICBitmapInterpolationModeFant = 3,
    WICBitmapInterpolationModeHighQualityCubic = 4,
}
