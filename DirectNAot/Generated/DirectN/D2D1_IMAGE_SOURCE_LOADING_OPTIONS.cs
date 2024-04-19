namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ne-d2d1_3-d2d1_image_source_loading_options
[Flags]
public enum D2D1_IMAGE_SOURCE_LOADING_OPTIONS
{
    D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE = 0,
    D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE = 1,
    D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND = 2,
}
