﻿namespace DirectN;

[Flags]
public enum MMSSF_GET_INFORMATION_FLAGS
{
    MMSSF_HASCLOCK = 1,
    MMSSF_SUPPORTSEEK = 2,
    MMSSF_ASYNCHRONOUS = 4,
}
