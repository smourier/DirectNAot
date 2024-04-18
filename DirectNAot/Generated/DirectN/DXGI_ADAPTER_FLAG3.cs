﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi1_6/ne-dxgi1_6-dxgi_adapter_flag3
public enum DXGI_ADAPTER_FLAG3
{
    DXGI_ADAPTER_FLAG3_NONE = 0,
    DXGI_ADAPTER_FLAG3_REMOTE = 1,
    DXGI_ADAPTER_FLAG3_SOFTWARE = 2,
    DXGI_ADAPTER_FLAG3_ACG_COMPATIBLE = 4,
    DXGI_ADAPTER_FLAG3_SUPPORT_MONITORED_FENCES = 8,
    DXGI_ADAPTER_FLAG3_SUPPORT_NON_MONITORED_FENCES = 16,
    DXGI_ADAPTER_FLAG3_KEYED_MUTEX_CONFORMANCE = 32,
}
