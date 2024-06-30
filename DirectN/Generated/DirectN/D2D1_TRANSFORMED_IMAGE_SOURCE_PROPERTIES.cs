#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/ns-d2d1_3-d2d1_transformed_image_source_properties
public partial struct D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES
{
    public D2D1_ORIENTATION orientation;
    public float scaleX;
    public float scaleY;
    public D2D1_INTERPOLATION_MODE interpolationMode;
    public D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS options;
}
