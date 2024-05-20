﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ne-winuser-ar_state
[Flags]
public enum AR_STATE
{
    AR_ENABLED = 0,
    AR_DISABLED = 1,
    AR_SUPPRESSED = 2,
    AR_REMOTESESSION = 4,
    AR_MULTIMON = 8,
    AR_NOSENSOR = 16,
    AR_NOT_SUPPORTED = 32,
    AR_DOCKED = 64,
    AR_LAPTOP = 128,
}
