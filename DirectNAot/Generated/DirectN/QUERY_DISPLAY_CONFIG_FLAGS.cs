﻿#nullable enable
namespace DirectN;

[Flags]
public enum QUERY_DISPLAY_CONFIG_FLAGS : uint
{
    QDC_ALL_PATHS = 1,
    QDC_ONLY_ACTIVE_PATHS = 2,
    QDC_DATABASE_CURRENT = 4,
    QDC_VIRTUAL_MODE_AWARE = 16,
    QDC_INCLUDE_HMD = 32,
    QDC_VIRTUAL_REFRESH_RATE_AWARE = 64,
}
