#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/ne-xpsobjectmodel-xps_segment_type
public enum XPS_SEGMENT_TYPE
{
    XPS_SEGMENT_TYPE_ARC_LARGE_CLOCKWISE = 1,
    XPS_SEGMENT_TYPE_ARC_LARGE_COUNTERCLOCKWISE = 2,
    XPS_SEGMENT_TYPE_ARC_SMALL_CLOCKWISE = 3,
    XPS_SEGMENT_TYPE_ARC_SMALL_COUNTERCLOCKWISE = 4,
    XPS_SEGMENT_TYPE_BEZIER = 5,
    XPS_SEGMENT_TYPE_LINE = 6,
    XPS_SEGMENT_TYPE_QUADRATIC_BEZIER = 7,
}
