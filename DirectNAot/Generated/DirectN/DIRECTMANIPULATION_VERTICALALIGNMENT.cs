﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/ne-directmanipulation-directmanipulation_verticalalignment
[Flags]
public enum DIRECTMANIPULATION_VERTICALALIGNMENT
{
    DIRECTMANIPULATION_VERTICALALIGNMENT_NONE = 0,
    DIRECTMANIPULATION_VERTICALALIGNMENT_TOP = 1,
    DIRECTMANIPULATION_VERTICALALIGNMENT_CENTER = 2,
    DIRECTMANIPULATION_VERTICALALIGNMENT_BOTTOM = 4,
    DIRECTMANIPULATION_VERTICALALIGNMENT_UNLOCKCENTER = 8,
}
