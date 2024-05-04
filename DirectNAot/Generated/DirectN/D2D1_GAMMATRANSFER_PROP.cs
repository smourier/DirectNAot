﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effects/ne-d2d1effects-d2d1_gammatransfer_prop
public enum D2D1_GAMMATRANSFER_PROP
{
    D2D1_GAMMATRANSFER_PROP_RED_AMPLITUDE = 0,
    D2D1_GAMMATRANSFER_PROP_RED_EXPONENT = 1,
    D2D1_GAMMATRANSFER_PROP_RED_OFFSET = 2,
    D2D1_GAMMATRANSFER_PROP_RED_DISABLE = 3,
    D2D1_GAMMATRANSFER_PROP_GREEN_AMPLITUDE = 4,
    D2D1_GAMMATRANSFER_PROP_GREEN_EXPONENT = 5,
    D2D1_GAMMATRANSFER_PROP_GREEN_OFFSET = 6,
    D2D1_GAMMATRANSFER_PROP_GREEN_DISABLE = 7,
    D2D1_GAMMATRANSFER_PROP_BLUE_AMPLITUDE = 8,
    D2D1_GAMMATRANSFER_PROP_BLUE_EXPONENT = 9,
    D2D1_GAMMATRANSFER_PROP_BLUE_OFFSET = 10,
    D2D1_GAMMATRANSFER_PROP_BLUE_DISABLE = 11,
    D2D1_GAMMATRANSFER_PROP_ALPHA_AMPLITUDE = 12,
    D2D1_GAMMATRANSFER_PROP_ALPHA_EXPONENT = 13,
    D2D1_GAMMATRANSFER_PROP_ALPHA_OFFSET = 14,
    D2D1_GAMMATRANSFER_PROP_ALPHA_DISABLE = 15,
    D2D1_GAMMATRANSFER_PROP_CLAMP_OUTPUT = 16,
}
