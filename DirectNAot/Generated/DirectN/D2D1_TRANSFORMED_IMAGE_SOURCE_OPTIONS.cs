namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ne-d2d1_3-d2d1_transformed_image_source_options
[Flags]
public enum D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS
{
    D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS_NONE = 0,
    D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS_DISABLE_DPI_SCALE = 1,
}
