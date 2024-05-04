#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ne-d2d1effectauthor-d2d1_blend_operation
public enum D2D1_BLEND_OPERATION
{
    D2D1_BLEND_OPERATION_ADD = 1,
    D2D1_BLEND_OPERATION_SUBTRACT = 2,
    D2D1_BLEND_OPERATION_REV_SUBTRACT = 3,
    D2D1_BLEND_OPERATION_MIN = 4,
    D2D1_BLEND_OPERATION_MAX = 5,
}
