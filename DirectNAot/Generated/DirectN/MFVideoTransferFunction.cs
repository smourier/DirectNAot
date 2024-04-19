﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfvideotransferfunction
public enum MFVideoTransferFunction
{
    MFVideoTransFunc_Unknown = 0,
    MFVideoTransFunc_10 = 1,
    MFVideoTransFunc_18 = 2,
    MFVideoTransFunc_20 = 3,
    MFVideoTransFunc_22 = 4,
    MFVideoTransFunc_709 = 5,
    MFVideoTransFunc_240M = 6,
    MFVideoTransFunc_sRGB = 7,
    MFVideoTransFunc_28 = 8,
    MFVideoTransFunc_Log_100 = 9,
    MFVideoTransFunc_Log_316 = 10,
    MFVideoTransFunc_709_sym = 11,
    MFVideoTransFunc_2020_const = 12,
    MFVideoTransFunc_2020 = 13,
    MFVideoTransFunc_26 = 14,
    MFVideoTransFunc_2084 = 15,
    MFVideoTransFunc_HLG = 16,
    MFVideoTransFunc_10_rel = 17,
    MFVideoTransFunc_Last = 18,
    MFVideoTransFunc_ForceDWORD = int.MaxValue,
}
