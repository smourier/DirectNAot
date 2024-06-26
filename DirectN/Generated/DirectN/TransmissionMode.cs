﻿#nullable enable
namespace DirectN;

public enum TransmissionMode
{
    BDA_XMIT_MODE_NOT_SET = -1,
    BDA_XMIT_MODE_NOT_DEFINED = 0,
    BDA_XMIT_MODE_2K = 1,
    BDA_XMIT_MODE_8K = 2,
    BDA_XMIT_MODE_4K = 3,
    BDA_XMIT_MODE_2K_INTERLEAVED = 4,
    BDA_XMIT_MODE_4K_INTERLEAVED = 5,
    BDA_XMIT_MODE_1K = 6,
    BDA_XMIT_MODE_16K = 7,
    BDA_XMIT_MODE_32K = 8,
    BDA_XMIT_MODE_MAX = 9,
}
