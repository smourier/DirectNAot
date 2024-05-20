#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ne-d2d1effectauthor-d2d1_vertex_options
[Flags]
public enum D2D1_VERTEX_OPTIONS
{
    D2D1_VERTEX_OPTIONS_NONE = 0,
    D2D1_VERTEX_OPTIONS_DO_NOT_CLEAR = 1,
    D2D1_VERTEX_OPTIONS_USE_DEPTH_BUFFER = 2,
    D2D1_VERTEX_OPTIONS_ASSUME_NO_OVERLAP = 4,
}
