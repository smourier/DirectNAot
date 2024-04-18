﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ne-dcomptypes-dcomposition_composite_mode
public enum DCOMPOSITION_COMPOSITE_MODE
{
    DCOMPOSITION_COMPOSITE_MODE_SOURCE_OVER = 0,
    DCOMPOSITION_COMPOSITE_MODE_DESTINATION_INVERT = 1,
    DCOMPOSITION_COMPOSITE_MODE_MIN_BLEND = 2,
    DCOMPOSITION_COMPOSITE_MODE_INHERIT = -1,
}
