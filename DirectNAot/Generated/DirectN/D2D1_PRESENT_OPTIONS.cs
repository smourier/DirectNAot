namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1/ne-d2d1-d2d1_present_options
[Flags]
public enum D2D1_PRESENT_OPTIONS
{
    D2D1_PRESENT_OPTIONS_NONE = 0,
    D2D1_PRESENT_OPTIONS_RETAIN_CONTENTS = 1,
    D2D1_PRESENT_OPTIONS_IMMEDIATELY = 2,
}
