﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ne-d2d1_1-d2d1_map_options
[Flags]
public enum D2D1_MAP_OPTIONS
{
    D2D1_MAP_OPTIONS_NONE = 0,
    D2D1_MAP_OPTIONS_READ = 1,
    D2D1_MAP_OPTIONS_WRITE = 2,
    D2D1_MAP_OPTIONS_DISCARD = 4,
}
