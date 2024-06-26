﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ne-d2d1_1-d2d1_buffer_precision
public enum D2D1_BUFFER_PRECISION
{
    D2D1_BUFFER_PRECISION_UNKNOWN = 0,
    D2D1_BUFFER_PRECISION_8BPC_UNORM = 1,
    D2D1_BUFFER_PRECISION_8BPC_UNORM_SRGB = 2,
    D2D1_BUFFER_PRECISION_16BPC_UNORM = 3,
    D2D1_BUFFER_PRECISION_16BPC_FLOAT = 4,
    D2D1_BUFFER_PRECISION_32BPC_FLOAT = 5,
}
