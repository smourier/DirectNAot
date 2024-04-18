namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_combine_mode
public enum D2D1_COMBINE_MODE
{
    D2D1_COMBINE_MODE_UNION = 0,
    D2D1_COMBINE_MODE_INTERSECT = 1,
    D2D1_COMBINE_MODE_XOR = 2,
    D2D1_COMBINE_MODE_EXCLUDE = 3,
}
