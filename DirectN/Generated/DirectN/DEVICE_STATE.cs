﻿#nullable enable
namespace DirectN;

public enum DEVICE_STATE : uint
{
    DEVICE_STATE_ACTIVE = 1,
    DEVICE_STATE_DISABLED = 2,
    DEVICE_STATE_NOTPRESENT = 4,
    DEVICE_STATE_UNPLUGGED = 8,
}
