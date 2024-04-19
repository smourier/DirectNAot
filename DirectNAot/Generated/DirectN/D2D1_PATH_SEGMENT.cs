namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_path_segment
[Flags]
public enum D2D1_PATH_SEGMENT
{
    D2D1_PATH_SEGMENT_NONE = 0,
    D2D1_PATH_SEGMENT_FORCE_UNSTROKED = 1,
    D2D1_PATH_SEGMENT_FORCE_ROUND_LINE_JOIN = 2,
}
