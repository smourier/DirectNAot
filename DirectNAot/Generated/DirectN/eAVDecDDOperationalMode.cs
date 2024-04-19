﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavdecddoperationalmode
public enum eAVDecDDOperationalMode
{
    eAVDecDDOperationalMode_NONE = 0,
    eAVDecDDOperationalMode_LINE = 1,
    eAVDecDDOperationalMode_RF = 2,
    eAVDecDDOperationalMode_CUSTOM0 = 3,
    eAVDecDDOperationalMode_CUSTOM1 = 4,
    eAVDecDDOperationalMode_PORTABLE8 = 5,
    eAVDecDDOperationalMode_PORTABLE11 = 6,
    eAVDecDDOperationalMode_PORTABLE14 = 7,
}
