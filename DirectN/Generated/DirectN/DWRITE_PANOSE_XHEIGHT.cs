﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ne-dwrite_1-dwrite_panose_xheight
public enum DWRITE_PANOSE_XHEIGHT
{
    DWRITE_PANOSE_XHEIGHT_ANY = 0,
    DWRITE_PANOSE_XHEIGHT_NO_FIT = 1,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_SMALL = 2,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_STANDARD = 3,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_LARGE = 4,
    DWRITE_PANOSE_XHEIGHT_DUCKING_SMALL = 5,
    DWRITE_PANOSE_XHEIGHT_DUCKING_STANDARD = 6,
    DWRITE_PANOSE_XHEIGHT_DUCKING_LARGE = 7,
    DWRITE_PANOSE_XHEIGHT_CONSTANT_STD = 3,
    DWRITE_PANOSE_XHEIGHT_DUCKING_STD = 6,
}
