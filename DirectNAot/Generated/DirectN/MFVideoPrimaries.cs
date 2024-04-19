﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfvideoprimaries
public enum MFVideoPrimaries
{
    MFVideoPrimaries_Unknown = 0,
    MFVideoPrimaries_reserved = 1,
    MFVideoPrimaries_BT709 = 2,
    MFVideoPrimaries_BT470_2_SysM = 3,
    MFVideoPrimaries_BT470_2_SysBG = 4,
    MFVideoPrimaries_SMPTE170M = 5,
    MFVideoPrimaries_SMPTE240M = 6,
    MFVideoPrimaries_EBU3213 = 7,
    MFVideoPrimaries_SMPTE_C = 8,
    MFVideoPrimaries_BT2020 = 9,
    MFVideoPrimaries_XYZ = 10,
    MFVideoPrimaries_DCI_P3 = 11,
    MFVideoPrimaries_ACES = 12,
    MFVideoPrimaries_Last = 13,
    MFVideoPrimaries_ForceDWORD = 2147483647,
}
