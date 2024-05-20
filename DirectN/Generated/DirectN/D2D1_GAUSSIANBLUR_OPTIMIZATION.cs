#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effects/ne-d2d1effects-d2d1_gaussianblur_optimization
public enum D2D1_GAUSSIANBLUR_OPTIMIZATION
{
    D2D1_GAUSSIANBLUR_OPTIMIZATION_SPEED = 0,
    D2D1_GAUSSIANBLUR_OPTIMIZATION_BALANCED = 1,
    D2D1_GAUSSIANBLUR_OPTIMIZATION_QUALITY = 2,
}
