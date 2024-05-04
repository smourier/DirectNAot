﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxvahd/ne-dxvahd-dxvahd_itelecine_caps
public enum DXVAHD_ITELECINE_CAPS
{
    DXVAHD_ITELECINE_CAPS_32 = 1,
    DXVAHD_ITELECINE_CAPS_22 = 2,
    DXVAHD_ITELECINE_CAPS_2224 = 4,
    DXVAHD_ITELECINE_CAPS_2332 = 8,
    DXVAHD_ITELECINE_CAPS_32322 = 16,
    DXVAHD_ITELECINE_CAPS_55 = 32,
    DXVAHD_ITELECINE_CAPS_64 = 64,
    DXVAHD_ITELECINE_CAPS_87 = 128,
    DXVAHD_ITELECINE_CAPS_222222222223 = 256,
    DXVAHD_ITELECINE_CAPS_OTHER = int.MinValue,
}
