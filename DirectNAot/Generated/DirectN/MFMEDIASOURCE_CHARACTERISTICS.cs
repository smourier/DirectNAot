﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfmediasource_characteristics
public enum MFMEDIASOURCE_CHARACTERISTICS
{
    MFMEDIASOURCE_IS_LIVE = 1,
    MFMEDIASOURCE_CAN_SEEK = 2,
    MFMEDIASOURCE_CAN_PAUSE = 4,
    MFMEDIASOURCE_HAS_SLOW_SEEK = 8,
    MFMEDIASOURCE_HAS_MULTIPLE_PRESENTATIONS = 16,
    MFMEDIASOURCE_CAN_SKIPFORWARD = 32,
    MFMEDIASOURCE_CAN_SKIPBACKWARD = 64,
    MFMEDIASOURCE_DOES_NOT_USE_NETWORK = 128,
}
