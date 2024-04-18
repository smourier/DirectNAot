﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/ne-wincodec-wicbitmapdithertype
public enum WICBitmapDitherType
{
    WICBitmapDitherTypeNone = 0,
    WICBitmapDitherTypeSolid = 0,
    WICBitmapDitherTypeOrdered4x4 = 1,
    WICBitmapDitherTypeOrdered8x8 = 2,
    WICBitmapDitherTypeOrdered16x16 = 3,
    WICBitmapDitherTypeSpiral4x4 = 4,
    WICBitmapDitherTypeSpiral8x8 = 5,
    WICBitmapDitherTypeDualSpiral4x4 = 6,
    WICBitmapDitherTypeDualSpiral8x8 = 7,
    WICBitmapDitherTypeErrorDiffusion = 8,
}
