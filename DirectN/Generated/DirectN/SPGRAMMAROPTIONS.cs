﻿#nullable enable
namespace DirectN;

public enum SPGRAMMAROPTIONS
{
    SPGO_SAPI = 1,
    SPGO_SRGS = 2,
    SPGO_UPS = 4,
    SPGO_SRGS_MS_SCRIPT = 8,
    SPGO_SRGS_W3C_SCRIPT = 256,
    SPGO_SRGS_STG_SCRIPT = 512,
    SPGO_SRGS_SCRIPT = 778,
    SPGO_FILE = 16,
    SPGO_HTTP = 32,
    SPGO_RES = 64,
    SPGO_OBJECT = 128,
    SPGO_DEFAULT = 1019,
    SPGO_ALL = 1023,
}
