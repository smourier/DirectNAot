﻿namespace DirectN;

[Flags]
public enum MFT_ENUM_FLAG
{
    MFT_ENUM_FLAG_SYNCMFT = 1,
    MFT_ENUM_FLAG_ASYNCMFT = 2,
    MFT_ENUM_FLAG_HARDWARE = 4,
    MFT_ENUM_FLAG_FIELDOFUSE = 8,
    MFT_ENUM_FLAG_LOCALMFT = 16,
    MFT_ENUM_FLAG_TRANSCODE_ONLY = 32,
    MFT_ENUM_FLAG_SORTANDFILTER = 64,
    MFT_ENUM_FLAG_SORTANDFILTER_APPROVED_ONLY = 192,
    MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY = 320,
    MFT_ENUM_FLAG_SORTANDFILTER_WEB_ONLY_EDGEMODE = 576,
    MFT_ENUM_FLAG_UNTRUSTED_STOREMFT = 1024,
    MFT_ENUM_FLAG_ALL = 63,
}
