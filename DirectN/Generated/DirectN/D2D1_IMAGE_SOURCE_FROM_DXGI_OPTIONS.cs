#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ne-d2d1_3-d2d1_image_source_from_dxgi_options
[Flags]
public enum D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS
{
    D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_NONE = 0,
    D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS_LOW_QUALITY_PRIMARY_CONVERSION = 1,
}
