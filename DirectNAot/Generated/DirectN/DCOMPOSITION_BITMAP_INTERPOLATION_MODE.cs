#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ne-dcomptypes-dcomposition_bitmap_interpolation_mode
public enum DCOMPOSITION_BITMAP_INTERPOLATION_MODE
{
    DCOMPOSITION_BITMAP_INTERPOLATION_MODE_NEAREST_NEIGHBOR = 0,
    DCOMPOSITION_BITMAP_INTERPOLATION_MODE_LINEAR = 1,
    DCOMPOSITION_BITMAP_INTERPOLATION_MODE_INHERIT = -1,
}
